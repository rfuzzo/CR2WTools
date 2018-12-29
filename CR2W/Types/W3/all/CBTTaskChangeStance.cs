using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangeStance : IBehTreeTask
{
#region RED Properties

[REDProp("newStance")]
public ENpcStance NewStance { get; set;}

[REDProp("setPrevStanceOnDeactivation")]
public bool SetPrevStanceOnDeactivation { get; set;}

[REDProp("oldStance")]
public ENpcStance OldStance { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("changeToFlyOnlyIfAboveGround")]
public bool ChangeToFlyOnlyIfAboveGround { get; set;}

#endregion
}
}