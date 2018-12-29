using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDettlaffDashDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("OpenForAard")]
public bool OpenForAard { get; set;}

[REDProp("shouldCheckVisibility")]
public bool ShouldCheckVisibility { get; set;}

[REDProp("shouldSignalGameplayEvent")]
public bool ShouldSignalGameplayEvent { get; set;}

#endregion
}
}