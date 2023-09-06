using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "simplePoint")]
	public class SimplePoint
	{
		private string id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id != null?  this.id : "";
			}
}
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name != null?  this.name : "";
			}
}
		[XmlAttribute]
		public uint reversalTime;
		private string mainTrack;
		[XmlAttribute(AttributeName = "mainTrack")]
		public string MainTrack
		{
			set
			{
				this.mainTrack = value;
			}
			get
			{
				return this.mainTrack != null?  this.mainTrack : "";
			}
}
		private string branchTrack;
		[XmlAttribute(AttributeName = "branchTrack")]
		public string BranchTrack
		{
			set
			{
				this.branchTrack = value;
			}
			get
			{
				return this.branchTrack != null?  this.branchTrack : "";
			}
}

	}
}
