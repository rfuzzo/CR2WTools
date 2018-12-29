using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBombardmentAttackDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("initialDelay")]
public float InitialDelay { get; set;}

[REDProp("afterSpawnDelay")]
public float AfterSpawnDelay { get; set;}

[REDProp("yOffset")]
public float YOffset { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

#endregion
}
}