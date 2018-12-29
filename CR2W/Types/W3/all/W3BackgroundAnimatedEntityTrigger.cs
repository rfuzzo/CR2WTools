using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BackgroundAnimatedEntityTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("movingEntitySpawnerHandle")]
public EntityHandle MovingEntitySpawnerHandle { get; set;}

[REDProp("movingEntitySpawner")]
public Handle<W3BackgroundAnimatedEntity> MovingEntitySpawner { get; set;}

#endregion
}
}