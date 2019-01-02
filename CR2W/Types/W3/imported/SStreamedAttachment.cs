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
    public class SStreamedAttachment : CResource
    {
        #region RED Properties

        [REDProp("parentName")]
        public CName ParentName { get; set; }

        [REDProp("parentClass")]
        public CName ParentClass { get; set; }

        [REDProp("childName")]
        public CName ChildName { get; set; }

        [REDProp("childClass")]
        public CName ChildClass { get; set; }

        [REDProp("data", 2,0)]
        public Array<byte> Data { get; set;}

        #endregion

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /*
             * 
            var typeId = br.ReadInt16();
            var datasize = br.ReadUInt32() - 4;


            //construct class
            
            using (var br = new CR2WBinaryReader(buffer, false))
            {
                List<CObject> bufferobjects = new List<CObject>();
                for (int i = 0; i < br.sobjs.Length; i++)
                {
                    bufferobjects.Add(br.CreateObject(br.sobjs[i]));
                }
                databuffer.buffer = bufferobjects;
            }
            */
        }
    }
}