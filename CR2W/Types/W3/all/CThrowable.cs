using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CThrowable : CProjectileTrajectory
{
#region RED Properties

[REDProp("ownerHandle")]
public EntityHandle OwnerHandle { get; set;}

[REDProp("wasThrown")]
public bool WasThrown { get; set;}

[REDProp("itemId")]
public SItemUniqueId ItemId { get; set;}

[REDProp("isFromAimThrow")]
public bool IsFromAimThrow { get; set;}

#endregion
}
}