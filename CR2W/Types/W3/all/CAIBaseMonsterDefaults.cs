using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIBaseMonsterDefaults : CAIDefaults
{
#region RED Properties

[REDProp("spawnTree")]
public Handle<CAIMonsterSpawn> SpawnTree { get; set;}

[REDProp("keepDistance")]
public Handle<CAIKeepDistanceTree> KeepDistance { get; set;}

[REDProp("tauntTree")]
public Handle<CAIMonsterTaunt> TauntTree { get; set;}

[REDProp("axiiTree")]
public Handle<CAIMonsterAxii> AxiiTree { get; set;}

[REDProp("idleDecoratorTree")]
public Handle<CAIMonsterIdleDecorator> IdleDecoratorTree { get; set;}

[REDProp("idleTree")]
public Handle<CAIIdleTree> IdleTree { get; set;}

[REDProp("ignoreReachability")]
public bool IgnoreReachability { get; set;}

[REDProp("allowPursueDistance")]
public float AllowPursueDistance { get; set;}

[REDProp("canSwim")]
public bool CanSwim { get; set;}

[REDProp("canBury")]
public bool CanBury { get; set;}

[REDProp("canKeepDistance")]
public bool CanKeepDistance { get; set;}

#endregion
}
}