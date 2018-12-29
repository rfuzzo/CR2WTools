using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFurStiffness 
{
#region RED Properties

[REDProp("stiffness")]
public float Stiffness { get; set;}

[REDProp("stiffnessStrength")]
public float StiffnessStrength { get; set;}

[REDProp("stiffnessTex")]
public Handle<CBitmapTexture> StiffnessTex { get; set;}

[REDProp("stiffnessTexChannel")]
public EHairTextureChannel StiffnessTexChannel { get; set;}

[REDProp("interactionStiffness")]
public float InteractionStiffness { get; set;}

[REDProp("pinStiffness")]
public float PinStiffness { get; set;}

[REDProp("rootStiffness")]
public float RootStiffness { get; set;}

[REDProp("rootStiffnessTex")]
public Handle<CBitmapTexture> RootStiffnessTex { get; set;}

[REDProp("rootStiffnessTexChannel")]
public EHairTextureChannel RootStiffnessTexChannel { get; set;}

[REDProp("stiffnessDamping")]
public float StiffnessDamping { get; set;}

[REDProp("tipStiffness")]
public float TipStiffness { get; set;}

[REDProp("bendStiffness")]
public float BendStiffness { get; set;}

[REDProp("stiffnessBoneEnable")]
public bool StiffnessBoneEnable { get; set;}

[REDProp("stiffnessBoneIndex")]
public uint StiffnessBoneIndex { get; set;}

[REDProp("stiffnessBoneAxis")]
public uint StiffnessBoneAxis { get; set;}

[REDProp("stiffnessStartDistance")]
public float StiffnessStartDistance { get; set;}

[REDProp("stiffnessEndDistance")]
public float StiffnessEndDistance { get; set;}

[REDProp("stiffnessBoneCurve")]
public Vector StiffnessBoneCurve { get; set;}

[REDProp("stiffnessCurve")]
public Vector StiffnessCurve { get; set;}

[REDProp("stiffnessStrengthCurve")]
public Vector StiffnessStrengthCurve { get; set;}

[REDProp("stiffnessDampingCurve")]
public Vector StiffnessDampingCurve { get; set;}

[REDProp("bendStiffnessCurve")]
public Vector BendStiffnessCurve { get; set;}

[REDProp("interactionStiffnessCurve")]
public Vector InteractionStiffnessCurve { get; set;}

#endregion
}
}