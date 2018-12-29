using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodePredefinedPathRuberBandDefinition : CBehTreeNodePredefinedPathDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("steeringGraph")]
public CBehTreeValSteeringGraph SteeringGraph { get; set;}

[REDProp("moveType")]
public CBehTreeValEMoveType MoveType { get; set;}

[REDProp("moveSpeed")]
public CBehTreeValFloat MoveSpeed { get; set;}

[REDProp("pathName")]
public CBehTreeValCName PathName { get; set;}

[REDProp("upThePath")]
public CBehTreeValBool UpThePath { get; set;}

[REDProp("pathMargin")]
public CBehTreeValFloat PathMargin { get; set;}

[REDProp("tolerance")]
public CBehTreeValFloat Tolerance { get; set;}

[REDProp("arrivalDistance")]
public CBehTreeValFloat ArrivalDistance { get; set;}

[REDProp("useExplorations")]
public CBehTreeValBool UseExplorations { get; set;}

#endregion
}
}