using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTArrive : IMoveSteeringTask
{
#region RED Properties

[REDProp("rotationVar")]
public CName RotationVar { get; set;}

[REDProp("rotationEvent")]
public CName RotationEvent { get; set;}

[REDProp("rotationNotification")]
public CName RotationNotification { get; set;}

#endregion
}
}