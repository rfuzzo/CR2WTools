using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
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