using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CLayerInfo : /*ISerializable*/ CObject
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

        [REDProp("parent")]
        public Handle<CLayerGroup> parent { get; set; }

        /*public override ushort Flags { get; set; }
        public override uint Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e){}
        public override void OnDeSerialize(IFile source, REDEventArgs e){}*/

        //UNKNOWN BYTES
        // has a handle to the world resource
        public Handle<CLayerGroup> Parent { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            Parent = (Handle<CLayerGroup>)ParseProperty(br, typeof(Handle<CLayerGroup>), 4);
        }
    }
}