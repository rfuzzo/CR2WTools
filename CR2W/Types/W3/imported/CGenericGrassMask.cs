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
public class CGenericGrassMask : CResource
{
#region RED Properties

[REDProp("maskRes")]
public UInt32 MaskRes { get; set;}

#endregion
}
}