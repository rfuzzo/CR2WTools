using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskAnimalFlee : IBehTreeTask
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("heading")]
public float Heading { get; set;}

[REDProp("initialPosCheck")]
public bool InitialPosCheck { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

[REDProp("alertRadius")]
public float AlertRadius { get; set;}

[REDProp("ignoreEntitiesWithTag")]
public CName IgnoreEntitiesWithTag { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("initialPos")]
public Vector InitialPos { get; set;}

[REDProp("checkPos")]
public Vector CheckPos { get; set;}

#endregion
}
}