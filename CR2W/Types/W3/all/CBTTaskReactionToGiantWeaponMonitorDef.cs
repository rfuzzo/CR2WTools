using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionToGiantWeaponMonitorDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("effectResourceName")]
public CName EffectResourceName { get; set;}

[REDProp("playFxOnEffectEntity")]
public CName PlayFxOnEffectEntity { get; set;}

[REDProp("spawnZOffset")]
public float SpawnZOffset { get; set;}

#endregion
}
}