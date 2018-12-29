using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWraithSummonDoppelgangerDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("entityToSummonName")]
public CName EntityToSummonName { get; set;}

[REDProp("entityToSummon")]
public CName EntityToSummon { get; set;}

[REDProp("splitEffectEntityTemplate")]
public Handle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

[REDProp("summonOnAnimEvent")]
public CName SummonOnAnimEvent { get; set;}

[REDProp("numberToSummon")]
public Int32 NumberToSummon { get; set;}

[REDProp("summonPositionPattern")]
public ESpawnPositionPattern SummonPositionPattern { get; set;}

[REDProp("summonMaxDistance")]
public float SummonMaxDistance { get; set;}

[REDProp("summonMinDistance")]
public float SummonMinDistance { get; set;}

[REDProp("applyBlindnessRange")]
public float ApplyBlindnessRange { get; set;}

#endregion
}
}