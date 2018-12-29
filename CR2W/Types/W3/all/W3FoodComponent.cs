using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FoodComponent : W3ScentComponent
{
#region RED Properties

[REDProp("maxEater")]
public Int32 MaxEater { get; set;}

[REDProp("distanceToEat")]
public float DistanceToEat { get; set;}

[REDProp("startAngleToEat")]
public float StartAngleToEat { get; set;}

[REDProp("arcWidthToEat")]
public float ArcWidthToEat { get; set;}

[REDProp("m_Eaters")]
public Array<Handle<CActor>> M_Eaters { get; set;}

[REDProp("m_LockDistance")]
public float M_LockDistance { get; set;}

[REDProp("m_EatSlots")]
public Array<Vector> M_EatSlots { get; set;}

[REDProp("m_LastTimeEaten")]
public float M_LastTimeEaten { get; set;}

#endregion
}
}