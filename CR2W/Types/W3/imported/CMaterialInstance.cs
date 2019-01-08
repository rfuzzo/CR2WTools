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
public class CMaterialInstance : IMaterial
{
#region RED Properties

[REDProp("baseMaterial")]
public Handle<IMaterial> BaseMaterial { get; set;}

[REDProp("enableMask")]
public bool EnableMask { get; set;}

#endregion
}
}