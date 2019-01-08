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
    public struct SStreamedAttachment
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


        [TypeConverter(typeof(ExpandableObjectConverter))]
        public CObject Child { get; set; }

        
    }
}