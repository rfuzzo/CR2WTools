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
    public class CLayerGroup : /*ISerializable*/ CObject
    {
        #region RED Properties

        [REDProp("name")]
        public string Name { get; set;}

        [REDProp("depotPath")]
        public string DepotPath { get; set;}

        [REDProp("absolutePath")]
        public string AbsolutePath { get; set;}

        [REDProp("isVisibleOnStart")]
        public bool IsVisibleOnStart { get; set;}

        [REDProp("systemGroup")]
        public bool SystemGroup { get; set;}

        [REDProp("hasEmbeddedLayerInfos")]
        public bool HasEmbeddedLayerInfos { get; set;}

        [REDProp("idHash")]
        public UInt64 IdHash { get; set;}

        #endregion
        /*public override ushort Flags { get; set; }
        public override uint Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e){}
        public override void OnDeSerialize(IFile source, REDEventArgs e){}*/

        //UNKNOWN BYTES
        // has a handle to the world resource
        public Handle<CGameWorld> World { get; set; }
        // has a handle to the layergroup parent
        public Handle<CLayerGroup> LayergroupParent { get; set; }

        // array of layergroups children
        public int ChildrenGroupSize { get; set; }
        public List<Handle<CLayerGroup>> LayerGroupChildren { get; set; } //have it as list, because it's easier and not a cr2w array (the length is stored in a dynamicInt and not a UInt32)
        // array of layerInfo children
        public int ChildrenInfoSize { get; set; }
        public List<Handle<CLayerInfo>> LayerInfoChildren { get; set; } //have it as list, because it's easier and not a cr2w array (the length is stored in a dynamicInt and not a UInt32)


        //public CLayerGroup Layergroup { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);


            World = (Handle<CGameWorld>)ParseProperty(br, typeof(Handle<CGameWorld>), 4);
            LayergroupParent = (Handle<CLayerGroup>)ParseProperty(br, typeof(Handle<CLayerGroup>), 4);

            //FIXME this doesn't work, because (for some reason) the array here has it's length stored in a byte.
            /*LayerGroupChildren = (Array<Handle<CLayerGroup>>)ParseProperty(br, typeof(Array<Handle<CLayerGroup>>), 0);
            LayerInfoChildren = (Array<Handle<CLayerInfo>>)ParseProperty(br, typeof(Array<Handle<CLayerInfo>>), 0);*/


            
            ChildrenGroupSize = br.ReadDynamicInt();
            if (ChildrenGroupSize > 0)
            {
                LayerGroupChildren = new List<Handle<CLayerGroup>>();
                for (int i = 0; i < ChildrenGroupSize; i++)
                {
                    var temp = (Handle<CLayerGroup>)ParseProperty(br, typeof(Handle<CLayerGroup>), 4);
                    LayerGroupChildren.Add(temp);
                }
            }


            
            ChildrenInfoSize = br.ReadDynamicInt();
            if (ChildrenInfoSize > 0)
            {
                LayerInfoChildren = new List<Handle<CLayerInfo>>();
                for (int i = 0; i < ChildrenInfoSize; i++)
                {
                    var temp = (Handle<CLayerInfo>)ParseProperty(br, typeof(Handle<CLayerInfo>), 4);
                    LayerInfoChildren.Add(temp);
                }
            }


        }

    }
}