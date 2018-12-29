using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskStopEffectIfActive : IBehTreeTask
{
#region RED Properties

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("allEffects")]
public bool AllEffects { get; set;}

[REDProp("findActorByTag")]
public bool FindActorByTag { get; set;}

[REDProp("tagToFind")]
public CName TagToFind { get; set;}

#endregion
}
}