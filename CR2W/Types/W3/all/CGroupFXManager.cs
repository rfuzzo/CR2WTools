using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGroupFXManager : CGameplayEntity
{
#region RED Properties

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("randomDropMin")]
public float RandomDropMin { get; set;}

[REDProp("randomDropMax")]
public float RandomDropMax { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("ntities")]
public Array<Handle<CEntity>> Ntities { get; set;}

[REDProp("randomDrop")]
public float RandomDrop { get; set;}

#endregion
}
}