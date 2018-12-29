using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4CharacterPerksMenu : CR4MenuBase
{
#region RED Properties

[REDProp("moduleId")]
public Int32 ModuleId { get; set;}

#endregion
}
}