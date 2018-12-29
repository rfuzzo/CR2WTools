using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskVolumetricPursueTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("distanceOffset")]
public float DistanceOffset { get; set;}

[REDProp("heightOffset")]
public float HeightOffset { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("minHeight")]
public float MinHeight { get; set;}

[REDProp("completeWithSucces")]
public bool CompleteWithSucces { get; set;}

[REDProp("useAbsoluteHeightDifference")]
public bool UseAbsoluteHeightDifference { get; set;}

[REDProp("checkDistanceWithoutOffsets")]
public bool CheckDistanceWithoutOffsets { get; set;}

[REDProp("skipHeightCheck")]
public bool SkipHeightCheck { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

#endregion
}
}