using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Burning : W3CriticalDOTEffect
{
#region RED Properties

[REDProp("cachedMPAC")]
public Handle<CMovingPhysicalAgentComponent> CachedMPAC { get; set;}

[REDProp("glyphword12Delay")]
public float Glyphword12Delay { get; set;}

[REDProp("isWithGlyphword12")]
public bool IsWithGlyphword12 { get; set;}

[REDProp("glyphword12Fx")]
public Handle<W3VisualFx> Glyphword12Fx { get; set;}

[REDProp("glyphword12BurningChance")]
public float Glyphword12BurningChance { get; set;}

[REDProp("glyphword12NotBurnedEntities")]
public Array<Handle<CGameplayEntity>> Glyphword12NotBurnedEntities { get; set;}

#endregion
}
}