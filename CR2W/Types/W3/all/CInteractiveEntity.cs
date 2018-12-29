using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CInteractiveEntity : CR4MapPinEntity
{
#region RED Properties

[REDProp("bIsEnabled")]
public bool BIsEnabled { get; set;}

[REDProp("bIsActive")]
public bool BIsActive { get; set;}

#endregion
}
}