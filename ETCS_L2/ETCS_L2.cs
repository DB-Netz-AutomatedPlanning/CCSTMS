
using AutomatedPlanning_FrameWork;
using eng;
using infra;
using System.Linq;
using Topology;

namespace CCSTMS.ETCS_L2_Planning
{
    public class ETCS_L2
    {
        public void PlanETCS_L2(Infrastructure infra, EngArea engArea)
        {
            TVPS tVPS = new TVPS();
            tVPS.Plan(infra, engArea);

            ETCSmarker eTCSmarker = new ETCSmarker();
            eTCSmarker.Plan(infra, engArea);

            BaliseGroups baliseGroups = new BaliseGroups();
            baliseGroups.Plan(infra, engArea);

            Routes routes = new Routes(infra);
            var route1 = routes.GetRoute(infra, "f49dd0fc-1450-410c-8c4d-540868638625", "f3257b3e-d784-4903-8658-a58aa12c1f00", 0, 320000, false);
            var route2 = routes.GetRoute(infra, "f3257b3e-d784-4903-8658-a58aa12c1f00", "f49dd0fc-1450-410c-8c4d-540868638625", 0, 320000, false);
            var allroutes = routes.GetAllRoutes(infra, true);
        }
    }
    
}
