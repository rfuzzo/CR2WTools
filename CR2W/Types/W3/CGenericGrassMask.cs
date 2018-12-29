using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CGenericGrassMask : CResource
{
#region RED Properties

[REDProp("maskRes")]
public uint MaskRes { get; set;}

#endregion
}
}