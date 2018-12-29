using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GameEffectManager : CObject
{
#region RED Properties

[REDProp("effects")]
public Array<Handle<CBaseGameplayEffect>> Effects { get; set;}

[REDProp("effectNames")]
public Array<CName> EffectNames { get; set;}

[REDProp("isReady")]
public bool IsReady { get; set;}

[REDProp("effectIconTypes")]
public Array<SEffectIconType> EffectIconTypes { get; set;}

#endregion
}
}