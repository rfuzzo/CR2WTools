using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BlockGameplayActionsTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("blockedActions")]
public Array<EInputActionBlock> BlockedActions { get; set;}

[REDProp("sourceName")]
public CName SourceName { get; set;}

[REDProp("sheatheWeaponIfDrawn")]
public bool SheatheWeaponIfDrawn { get; set;}

#endregion
}
}