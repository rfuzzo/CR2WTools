using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterAxiiParams : CAIAxiiParameters
{
#region RED Properties

[REDProp("canFly")]
public bool CanFly { get; set;}

[REDProp("onSpotLanding")]
public bool OnSpotLanding { get; set;}

[REDProp("landingGroundOffset")]
public float LandingGroundOffset { get; set;}

#endregion
}
}