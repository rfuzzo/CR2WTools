using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterSearchFoodIdleParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("loopTime")]
public float LoopTime { get; set;}

[REDProp("corpse")]
public bool Corpse { get; set;}

[REDProp("meat")]
public bool Meat { get; set;}

[REDProp("vegetable")]
public bool Vegetable { get; set;}

[REDProp("water")]
public bool Water { get; set;}

[REDProp("monster")]
public bool Monster { get; set;}

[REDProp("landHeight")]
public float LandHeight { get; set;}

[REDProp("flyHeight")]
public float FlyHeight { get; set;}

#endregion
}
}