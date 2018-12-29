using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWraithSummonDoppelganger : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("splitEffectEntityTemplate")]
public Handle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

[REDProp("numberToSummon")]
public Int32 NumberToSummon { get; set;}

[REDProp("summonOnAnimEvent")]
public CName SummonOnAnimEvent { get; set;}

[REDProp("summonPositionPattern")]
public ESpawnPositionPattern SummonPositionPattern { get; set;}

[REDProp("summonMaxDistance")]
public float SummonMaxDistance { get; set;}

[REDProp("summonMinDistance")]
public float SummonMinDistance { get; set;}

[REDProp("entityToSummonName")]
public CName EntityToSummonName { get; set;}

[REDProp("splitEffectEntity")]
public CName SplitEffectEntity { get; set;}

[REDProp("applyBlindnessRange")]
public float ApplyBlindnessRange { get; set;}

[REDProp("entityToSummon")]
public Handle<CEntityTemplate> EntityToSummon { get; set;}

[REDProp("m_shouldSummon")]
public bool M_shouldSummon { get; set;}

[REDProp("m_hasSummoned")]
public bool M_hasSummoned { get; set;}

[REDProp("m_createEntityHelper")]
public Handle<CCreateEntityHelper> M_createEntityHelper { get; set;}

#endregion
}
}