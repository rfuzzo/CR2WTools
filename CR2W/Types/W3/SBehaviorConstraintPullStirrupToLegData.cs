using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorConstraintPullStirrupToLegData 
{
#region RED Properties

[REDProp("stirrupBoneName")]
public CName StirrupBoneName { get; set;}

[REDProp("stirrupContactPoint")]
public Vector StirrupContactPoint { get; set;}

[REDProp("footBoneName")]
public CName FootBoneName { get; set;}

[REDProp("footContactPoint")]
public Vector FootContactPoint { get; set;}

[REDProp("toeBoneName")]
public CName ToeBoneName { get; set;}

[REDProp("toeAlignStirrupSideDir")]
public Vector ToeAlignStirrupSideDir { get; set;}

[REDProp("toeAlignStirrupRotationAxisDir")]
public Vector ToeAlignStirrupRotationAxisDir { get; set;}

#endregion
}
}