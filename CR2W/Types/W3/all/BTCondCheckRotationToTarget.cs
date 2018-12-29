using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondCheckRotationToTarget : IBehTreeTask
{
#region RED Properties

[REDProp("ifNot")]
public bool IfNot { get; set;}

[REDProp("toleranceAngle")]
public float ToleranceAngle { get; set;}

#endregion
}
}