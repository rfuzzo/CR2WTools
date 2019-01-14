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
    public class CEntity : CNode
    {
        #region RED Properties

        [REDProp("tags")]
        public TagList Tags { get; set;}

        [REDProp("transform")]
        public EngineTransform Transform { get; set;}

        [REDProp("transformParent")]
        public Ptr<CHardAttachment> TransformParent { get; set;}

        [REDProp("guid")]
        public CGUID Guid { get; set;}

        [REDProp("components", 2,0)]
        public Array<Ptr<CComponent>> Components { get; set;}

        [REDProp("template")]
        public Handle<CEntityTemplate> Template { get; set;}

        [REDProp("streamingDataBuffer")]
        public SharedDataBuffer StreamingDataBuffer { get; set;}

        [REDProp("streamingDistance")]
        public byte StreamingDistance { get; set;}

        [REDProp("entityStaticFlags")]
        public EEntityStaticFlags EntityStaticFlags { get; set;}

        [REDProp("autoPlayEffectName")]
        public CName AutoPlayEffectName { get; set;}

        [REDProp("entityFlags")]
        public byte EntityFlags { get; set;}

        #endregion

        //UNKNOWN BYTES
        //public Array<Handle<CComponent>> Components { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            bool hasChildren = this.Children.Count > 0;

            if (hasChildren)
            {
                //2 times unknown 4bytes
                var unk1 = br.ReadUInt32();
                var unk2 = br.ReadUInt32();
                //length one byte (wkit has it as bit6, I'm gonna read it as DynamicInt)
                var elementcount = br.ReadDynamicInt();
                if (elementcount > 0)
                {
                    var temparray = new Array<Ptr<CComponent>>();
                    for (int i = 0; i < elementcount; i++)
                    {
                        var temp = (Ptr<CComponent>)ParseProperty(br, typeof(Ptr<CComponent>), 4);
                        temparray.Add(temp);
                    }
                    Components = temparray;
                }
            }

        }
    }
}