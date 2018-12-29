using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRotateToEnemyDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("toleranceAngle")]
public float ToleranceAngle { get; set;}

[REDProp("rotateOnRotateEvent")]
public bool RotateOnRotateEvent { get; set;}

#endregion
}
}