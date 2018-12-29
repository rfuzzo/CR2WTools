using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBoatGrab : IBehTreeTask
{
#region RED Properties

[REDProp("m_Collided")]
public bool M_Collided { get; set;}

[REDProp("m_TargetBoat")]
public Handle<CEntity> M_TargetBoat { get; set;}

[REDProp("m_ClosestSlot")]
public CName M_ClosestSlot { get; set;}

#endregion
}
}