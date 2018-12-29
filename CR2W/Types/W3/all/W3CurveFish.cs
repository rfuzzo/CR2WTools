using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CurveFish : CGameplayEntity
{
#region RED Properties

[REDProp("destroyDistance")]
public float DestroyDistance { get; set;}

[REDProp("swimCurves")]
public Array<CName> SwimCurves { get; set;}

[REDProp("speedUpChance")]
public float SpeedUpChance { get; set;}

[REDProp("baseSpeedVariance")]
public float BaseSpeedVariance { get; set;}

[REDProp("maxSpeed")]
public float MaxSpeed { get; set;}

[REDProp("randomizedAppearances")]
public Array<string> RandomizedAppearances { get; set;}

[REDProp("manager")]
public Handle<W3CurveFishManager> Manager { get; set;}

[REDProp("baseSpeed")]
public float BaseSpeed { get; set;}

[REDProp("selectedSwimCurve")]
public CName SelectedSwimCurve { get; set;}

[REDProp("currentSpeed")]
public float CurrentSpeed { get; set;}

[REDProp("accelerate")]
public bool Accelerate { get; set;}

#endregion
}
}