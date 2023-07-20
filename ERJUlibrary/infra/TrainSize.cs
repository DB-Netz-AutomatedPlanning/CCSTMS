using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainSize")]
	public enum TrainSize
	{
        fullTrain,
        halfTrain,
        shortTrain
    }
}