using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TaskManageCapsuleCollision : IBehTreeTask
{
#region RED Properties

[REDProp("collision")]
public bool Collision { get; set;}

[REDProp("allCollisionTypes")]
public bool AllCollisionTypes { get; set;}

[REDProp("overrideForThisTaskOnly")]
public bool OverrideForThisTaskOnly { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("switchVulnerability")]
public bool SwitchVulnerability { get; set;}

[REDProp("effectLinkedToCollision")]
public CName EffectLinkedToCollision { get; set;}

#endregion
}
}