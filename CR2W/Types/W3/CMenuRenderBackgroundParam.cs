using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CMenuRenderBackgroundParam : CObject, IMenuDisplayParam
    {
        [REDProp("renderGameWorld")]
        public bool RenderGameWrold { get; set; }
    }
}