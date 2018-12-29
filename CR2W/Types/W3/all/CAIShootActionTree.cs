using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIShootActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("multipleTargetsTags")]
public Handle<W3BehTreeValNameArray> MultipleTargetsTags { get; set;}

[REDProp("numberOfActions")]
public Int32 NumberOfActions { get; set;}

[REDProp("setProjectileOnFire")]
public bool SetProjectileOnFire { get; set;}

[REDProp("afterActionIdleDuration")]
public float AfterActionIdleDuration { get; set;}

[REDProp("afterActionIdleDurationChance")]
public float AfterActionIdleDurationChance { get; set;}

[REDProp("useRayCastBeforeShooting")]
public bool UseRayCastBeforeShooting { get; set;}

#endregion
}
}