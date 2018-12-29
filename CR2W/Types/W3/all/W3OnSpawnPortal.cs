using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3OnSpawnPortal : CEntity
{
#region RED Properties

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("fxTimeout")]
public float FxTimeout { get; set;}

[REDProp("creatureAppearAfter")]
public float CreatureAppearAfter { get; set;}

[REDProp("spawnedActor")]
public Handle<CActor> SpawnedActor { get; set;}

#endregion
}
}