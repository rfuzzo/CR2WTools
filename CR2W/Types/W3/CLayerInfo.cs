using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CLayerInfo : ISerializable
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("layerType")]
public ELayerType LayerType { get; set;}

[REDProp("layerBuildTag")]
public ELayerBuildTag LayerBuildTag { get; set;}

[REDProp("layerMergeContentMode")]
public ELayerMergedContent LayerMergeContentMode { get; set;}

[REDProp("streamingLayer")]
public bool StreamingLayer { get; set;}

[REDProp("depotFilePath")]
public string DepotFilePath { get; set;}

[REDProp("shortName")]
public string ShortName { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("hasEmbeddedLayerInfo")]
public bool HasEmbeddedLayerInfo { get; set;}

        #endregion

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }
    }
}