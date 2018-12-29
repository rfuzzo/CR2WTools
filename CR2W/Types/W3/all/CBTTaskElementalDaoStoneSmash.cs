using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskElementalDaoStoneSmash : CBTTaskAttack
{
#region RED Properties

[REDProp("stoneEntityTemplate")]
public Handle<CEntityTemplate> StoneEntityTemplate { get; set;}

[REDProp("Stone1")]
public Handle<CEntity> Stone1 { get; set;}

[REDProp("Stone2")]
public Handle<CEntity> Stone2 { get; set;}

[REDProp("execute")]
public bool Execute { get; set;}

[REDProp("spawnDist")]
public float SpawnDist { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

#endregion
}
}