using infra;
using System.Collections.Generic;
using System.Linq;
using Topology;
using TheCore.Data;

namespace AutomatedPlanning_FrameWork
{
    public class Routes
    {
        private Graph graph;


        public Routes(Infrastructure infra)
        {
            var edges = EdgesWithNodes(infra, 0);
            graph = new Graph(edges);
        }
        public Dictionary<string, List<List<(string, bool)>>> GetAllRoutes(Infrastructure infra,bool withShunting)
        {
            var nodes = graph.GetEdgesWithNodes().Values.SelectMany(x => new List<int>() {x.Item1,x.Item2});

            var edgeNodes = nodes.GroupBy(x => x).Where(x => x.Count() == 1);

            Dictionary<string, List<List<(string, bool)>>> allPaths = new Dictionary<string, List<List<(string, bool)>>>();

            foreach (var startNode in edgeNodes)
            {
                foreach (var endNode in edgeNodes)
                {
                    var paths = graph.FindAllPaths(startNode.Key,endNode.Key);

                    foreach (var path in paths)
                    {
                        var pathEdges = GetPathEdges(path, graph.GetEdgesWithNodes(), infra, withShunting);
                        
                        if (pathEdges!=null && pathEdges.Count>0 && !allPaths.ContainsKey(pathEdges[0].Item1))
                        {
                            allPaths.Add(pathEdges[0].Item1, new() { pathEdges });
                        }
                        else if(pathEdges != null && pathEdges.Count > 0 && allPaths.ContainsKey(pathEdges[0].Item1))
                        {
                            allPaths[pathEdges[0].Item1].Add(pathEdges);
                        } 
                    }
                }
            }
            return allPaths;
        }

        public List<List<(string, List<(object, uint)>)>> GetRoute(Infrastructure infra,string start_edge_id, string end_edge_id,uint  startP,uint endP, bool withShunting)
        {
            var startNode = graph.GetEdgesWithNodes().FirstOrDefault(x => x.Key.Equals(start_edge_id)).Value.Item1;
            var endNode = graph.GetEdgesWithNodes().FirstOrDefault(x => x.Key.Equals(end_edge_id)).Value.Item2;

            var paths = graph.FindAllPaths(startNode, endNode);

            List<List<(string, bool)>> allPaths = new List<List<(string, bool)>>();

            //get possible path as edges.
            foreach (var path in paths)
            {
                var pathEdges = GetPathEdges(path, graph.GetEdgesWithNodes(), infra, withShunting);

                var pathEdgesIds = pathEdges.Select(x => x.Item1);

                // if that edge is missed due to graph theory
                if (!pathEdgesIds.Contains(start_edge_id))
                {
                    pathEdges= pathEdges.Prepend((start_edge_id,false)).ToList();
                }
                // if that edge is missed due to graph theory
                if (!pathEdgesIds.Contains(end_edge_id))
                {
                    pathEdges= pathEdges.Append((end_edge_id, false)).ToList();
                }

                if (LinkedEdges(infra, start_edge_id, pathEdges[0].Item1) || pathEdges[0].Item1.Equals(start_edge_id))
                {
                    if (pathEdges != null) allPaths.Add(pathEdges);
                }
            }

            List<List<(string, bool, List<object>)>> data = new();
            
            //collect data for each path.
            foreach (var item in allPaths)
            {
                data.Add(GetElementsOnRoute(item, infra));
            }

            List<List<(string,List<(object, uint)>)>> filteredData = new();

            // filter the data according to start and end points.
            data.ForEach(item =>
            {
                List<(string, List<(object, uint)>)> routeData = new();

                for (int i = 0; i < item.Count(); i++)
                {
                    List<(object,uint)> edgeData= new();

                    for (int j = 0; j < item.ElementAt(i).Item3.Count(); j++)
                    {
                        var x = item.ElementAt(i).Item3.ElementAt(j);
                        uint pos = 0;
                        if (x is TrainDetector) pos = (x as TrainDetector).pos;
                        if (x is ETCSMarker) pos = (x as ETCSMarker).pos;
                        if (x is BaliseGroup) pos = (x as BaliseGroup).balises != null && (x as BaliseGroup).balises.Count > 0 ? (x as BaliseGroup).balises[0].pos : 0;

                        if (item.ElementAt(i).Item1.Equals(start_edge_id))
                        {
                            if (pos >= startP) edgeData.Add((x, pos));
                        }
                        else if (item.ElementAt(i).Item1.Equals(end_edge_id))
                        {
                            if (pos <= endP) edgeData.Add((x, pos));
                        }
                        else
                        {
                            edgeData.Add((x, pos));
                        } 
                    }

                    //sort the data according to the direction of the edge.
                    if (item.ElementAt(i).Item2)
                    {
                        edgeData = edgeData.OrderBy(x => x.Item2).ToList();
                    }
                    else
                    {
                        edgeData = edgeData.OrderBy(x => x.Item2).ToList();
                    }

                    routeData.Add((item.ElementAt(i).Item1, edgeData));
                }
                filteredData.Add(routeData);
            });
            return filteredData;
        }

        #region helper functions
        private List<(string, bool, List<object>)> GetElementsOnRoute(List<(string,bool)> route, Infrastructure infra)
        {

            var routeEdges = route.Select(x => x.Item1);

            IEnumerable<object> flattened  = Data.FlattenLists(infra.functionalAreas[0].baliseGroups, infra.functionalAreas[0].etcsMarkers, infra.functionalAreas[0].trainDetectors);

            var data = flattened.GroupBy(x =>
            {
                if (x is TrainDetector) return (x as TrainDetector).trackEdge;
                if (x is ETCSMarker) return (x as ETCSMarker).trackEdge;
                if (x is BaliseGroup) return (x as BaliseGroup).balises != null && (x as BaliseGroup).balises.Count > 0 ? (x as BaliseGroup).balises[0].trackEdge : null;
                return null;
            }).Where(x => routeEdges.Contains(x.Key)).SelectMany(x=>new List<(string,bool, List<object>)>() { (x.Key, route.First(y=>y.Item1.Equals(x.Key)).Item2, x.ToList()) });

            List<(string,bool,List<object>)> sortedData = new();

            foreach (var edge in routeEdges)
            {
                sortedData.Add(data.First(x => x.Item1.Equals(edge)));
            }

            return sortedData;
        }
        private Dictionary<string, (int, int)> EdgesWithNodes(Infrastructure infra, int topoIndex)
        {
            Dictionary<int, List<(string, string)>> nodes = new Dictionary<int, List<(string, string)>>();

            var links = infra.topoAreas[topoIndex].trackEdgeLinks;

            int node = 0;
            
            // get nodes.
            for(int i=0; i<links.Count-1; i++)
            {
                nodes.Add(node, new List<(string, string)>() { (links[i].trackEdgeA, links[i].startOfA?"start":"end"), (links[i].trackEdgeB, links[i].startOfB ? "start" : "end") });

                for (int j = i+1; j < links.Count; j++)
                {
                    var startOnA = links[i].startOfA;

                    if (links[j].trackEdgeA.Equals(links[i].trackEdgeA) && links[j].startOfA == startOnA) nodes[node].Add((links[j].trackEdgeB, links[j].startOfB?"start":"end"));
                    if (links[j].trackEdgeB.Equals(links[i].trackEdgeA) && links[j].startOfB == startOnA) nodes[node].Add((links[j].trackEdgeA, links[j].startOfA?"start":"end"));
                }
                node++;
            }

            //remove any duplicate nodes.
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                for (int j = i + 1; j < nodes.Count; j++)
                {
                    bool contained = nodes[nodes.Keys.ElementAt(j)].All(element => nodes[nodes.Keys.ElementAt(i)].Contains(element));
                    if(contained) nodes.Remove(nodes.Keys.ElementAt(j));
                }
            }

            var edgeNodes = GetEdgesOnEdge(infra, 0, 0, node);

            edgeNodes.ToList().ForEach(x => nodes.Add(x.Key,x.Value));

            Dictionary<string, (int,int)> edges = new Dictionary<string, (int, int)>();

            for (int i = 0; i < nodes.Count - 1; i++)
            {
                for (int j = 0; j < nodes[nodes.Keys.ElementAt(i)].Count; j++)
                {
                    var cNode = nodes[nodes.Keys.ElementAt(i)];
                    var currentEdge = nodes[nodes.Keys.ElementAt(i)].ElementAt(j).Item1;
                    var currentEnd = nodes[nodes.Keys.ElementAt(i)].ElementAt(j).Item2;

                    for (int z = 0; z < nodes.Count; z++)
                    {
        
                        var OtherNodeFound = false;
                        var currentNode = nodes[nodes.Keys.ElementAt(z)];

                        foreach (var item in currentNode)
                        {
                            if (item.Item1.Equals(currentEdge) && !item.Item2.Equals(currentEnd)) OtherNodeFound = true;
                        }

                        if (OtherNodeFound && !edges.ContainsKey(currentEdge))
                        {
                            if (currentEnd.Equals("start"))
                            {
                                edges.Add(currentEdge, (nodes.Keys.ElementAt(i), nodes.Keys.ElementAt(z)));
                            }
                            else
                            {
                                edges.Add(currentEdge, (nodes.Keys.ElementAt(z), nodes.Keys.ElementAt(i)));
                            }
                        }
                    }
                } 
            }
            return edges;
        }
        private Dictionary<int, List<(string, string)>> GetEdgesOnEdge(Infrastructure infra, int topoIndex, int mapIndex, int nodeStartIndex)
        {
            //edges and the connected side to connections.
            var edgeInfos = infra.topoAreas.ElementAt(topoIndex).trackEdgeLinks.SelectMany(x =>
            {

                return new List<(string, bool, string)> { (x.trackEdgeA, x.startOfA, "A"), (x.trackEdgeB, x.startOfB, "B") };

            }).GroupBy(x => x.Item1);


            /*starting edges with a bool to incdicates if they are not connected from start or end.
             * start for connected from start.
             * end for connected from end.
             */
            Dictionary<int, List<(string, string)>> startingEdges = new Dictionary<int, List<(string, string)>>();

            var node = nodeStartIndex;
            foreach (var edgeInfo in edgeInfos)
            {
                var count = edgeInfo.Where((x, i) => i != 0 && (!x.Item2.Equals(edgeInfo.ElementAt(i - 1).Item2) || !x.Item3.Equals(edgeInfo.ElementAt(i - 1).Item3))).Count();
                if (count == 0)
                {
                    var trackEdge = infra.topoAreas[mapIndex].trackEdges.First(x => x.id.Equals(edgeInfo.ElementAt(0).Item1));
                    startingEdges.Add(node, new List<(string, string)>() { (edgeInfo.ElementAt(0).Item1, edgeInfo.ElementAt(0).Item2 ? "end" : "start") });
                    node++;
                }

            }
            return startingEdges;
        }
        private List<(string, bool)> GetPathEdges(List<int> nodes, Dictionary<string, (int, int)> edges,Infrastructure infra, bool withShunting)
        {
            var edgesNodes = SequenceToPairs(nodes);

            List<(string,bool)> result = new List<(string, bool)>();


            for (int i = 1; i < edgesNodes.Count(); i++)
            {
                var nodes1 = edgesNodes[i-1];
                var nodes2 = edgesNodes[i];

                var edge1 = edges.Keys.Where(x => {
                    edges.TryGetValue(x, out (int, int) n);

                    if ((n.Item1 == nodes1.Item1 && n.Item2 == nodes1.Item2) || (n.Item1 == nodes1.Item2 && n.Item2 == nodes1.Item1))
                    {
                        return true;
                    };
                    return false;
                }).Select(x =>
                {
                    edges.TryGetValue(x, out (int, int) n);
                    if (n.Item1 == nodes1.Item1 && n.Item2 == nodes1.Item2)
                    {
                        return (x,true);
                    }
                    if (n.Item1 == nodes1.Item2 && n.Item2 == nodes1.Item1)
                    {
                        return (x, false);
                    }
                    return (x,true);
                }).First();

                var edge2 = edges.Keys.Where(x => {
                    edges.TryGetValue(x, out (int, int) n);

                    if ((n.Item1 == nodes2.Item1 && n.Item2 == nodes2.Item2) || (n.Item1 == nodes2.Item2 && n.Item2 == nodes2.Item1))
                    {
                        return true;
                    };
                    return false;
                }).Select(x =>
                {
                    edges.TryGetValue(x, out (int, int) n);
                    if ((n.Item1 == nodes2.Item1 && n.Item2 == nodes2.Item2))
                    {
                        return (x, true);
                    }
                    if ((n.Item1 == nodes2.Item2 && n.Item2 == nodes2.Item1))
                    {
                        return (x, false);
                    }
                    return (x, true);
                }).First();

                if(!result.Contains(edge1)) result.Add(edge1);


                if (!withShunting)
                {
                    if (LinkedEdges(infra,edge1.x,edge2.x))
                    {
                        result.Add(edge2);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    result.Add(edge2);
                }
            }
            return result;
        }
        private List<(int,int)> SequenceToPairs(List<int> sequencedNodes)
        {
            var result = new List<(int, int)>();
            
            for (int i = 0; i < sequencedNodes.Count-1; i++)
            {
                result.Add((sequencedNodes[i], sequencedNodes[i+1]));
            }

            return result;
        }
        private bool LinkedEdges(Infrastructure infra,string e1,string e2)
        {
            var link = infra.topoAreas[0].trackEdgeLinks.FirstOrDefault(x =>
            {
                if (x.trackEdgeA.Equals(e1) && x.trackEdgeB.Equals(e2) || x.trackEdgeA.Equals(e2) && x.trackEdgeB.Equals(e1)) return true; 
                return false;
            });

            return link!=null?true:false;
        }
        #endregion
    }
}
