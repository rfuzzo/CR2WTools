using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VisualFx : CEntity
{
#region RED Properties

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("destroyEffectTime")]
public float DestroyEffectTime { get; set;}

[REDProp("timedFxDestroyName")]
public CName TimedFxDestroyName { get; set;}

[REDProp("parentActorHandle")]
public EntityHandle ParentActorHandle { get; set;}

#endregion
}
}