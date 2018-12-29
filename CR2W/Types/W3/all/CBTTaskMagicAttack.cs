using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicAttack : CBTTaskCollisionAttack
{
#region RED Properties

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("fxDummyEntityTag")]
public CName FxDummyEntityTag { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("dummyEntityEffectName")]
public CName DummyEntityEffectName { get; set;}

#endregion
}
}