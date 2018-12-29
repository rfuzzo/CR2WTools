using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDestroyEntityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("playEffectName")]
public CName PlayEffectName { get; set;}

[REDProp("stopEffectName")]
public CName StopEffectName { get; set;}

[REDProp("eventToRaise")]
public CName EventToRaise { get; set;}

[REDProp("playEffect")]
public bool PlayEffect { get; set;}

[REDProp("stopEffect")]
public bool StopEffect { get; set;}

[REDProp("destroyAfter")]
public float DestroyAfter { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}