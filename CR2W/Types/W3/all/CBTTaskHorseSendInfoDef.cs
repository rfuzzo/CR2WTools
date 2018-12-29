using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseSendInfoDef : IBehTreeHorseTaskDefinition
{
#region RED Properties

[REDProp("onIsAvailable")]
public bool OnIsAvailable { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDectivate")]
public bool OnDectivate { get; set;}

[REDProp("infoType")]
public EActionInfoType InfoType { get; set;}

[REDProp("notifyPlayerInsteadOfCombatTarget")]
public bool NotifyPlayerInsteadOfCombatTarget { get; set;}

#endregion
}
}