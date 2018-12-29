using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSTHorse : IMoveSteeringTask
{
#region RED Properties

[REDProp("horseSlowWalkMult")]
public float HorseSlowWalkMult { get; set;}

[REDProp("horseWalkMult")]
public float HorseWalkMult { get; set;}

[REDProp("horseTrotMult")]
public float HorseTrotMult { get; set;}

[REDProp("horseGallopMult")]
public float HorseGallopMult { get; set;}

[REDProp("horseCanterMult")]
public float HorseCanterMult { get; set;}

#endregion
}
}