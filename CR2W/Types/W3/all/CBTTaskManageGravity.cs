using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageGravity : IBehTreeTask
{
#region RED Properties

[REDProp("manageGravity")]
public EManageGravity ManageGravity { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onEvent")]
public bool OnEvent { get; set;}

[REDProp("setCustomMovement")]
public bool SetCustomMovement { get; set;}

#endregion
}
}