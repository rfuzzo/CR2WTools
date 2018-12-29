using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMoveAlongPathParams : IAIActionParameters
{
#region RED Properties

[REDProp("pathTag")]
public CName PathTag { get; set;}

[REDProp("upThePath")]
public bool UpThePath { get; set;}

[REDProp("fromBeginning")]
public bool FromBeginning { get; set;}

[REDProp("pathMargin")]
public float PathMargin { get; set;}

[REDProp("moveTypeBeforePath")]
public EMoveType MoveTypeBeforePath { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("steeringGraph")]
public Handle<CMoveSteeringBehavior> SteeringGraph { get; set;}

[REDProp("arrivalDistance")]
public float ArrivalDistance { get; set;}

[REDProp("rotateAfterReachStart")]
public bool RotateAfterReachStart { get; set;}

[REDProp("useExplorations")]
public bool UseExplorations { get; set;}

[REDProp("dontCareAboutNavigable")]
public bool DontCareAboutNavigable { get; set;}

[REDProp("tolerance")]
public float Tolerance { get; set;}

#endregion
}
}