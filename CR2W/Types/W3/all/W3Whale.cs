using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Whale : CGameplayEntity
{
#region RED Properties

[REDProp("whaleArea")]
public Handle<W3WhaleArea> WhaleArea { get; set;}

[REDProp("destroyTime")]
public float DestroyTime { get; set;}

[REDProp("alwaysSpawned")]
public bool AlwaysSpawned { get; set;}

[REDProp("canBeDestroyed")]
public bool CanBeDestroyed { get; set;}

[REDProp("spawnPosition")]
public Vector SpawnPosition { get; set;}

[REDProp("spawnRotation")]
public EulerAngles SpawnRotation { get; set;}

#endregion
}
}