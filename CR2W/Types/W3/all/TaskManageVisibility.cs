using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TaskManageVisibility : IBehTreeTask
{
#region RED Properties

[REDProp("visible")]
public bool Visible { get; set;}

[REDProp("changeMeshVisibility")]
public bool ChangeMeshVisibility { get; set;}

[REDProp("changeGameplayVisibility")]
public bool ChangeGameplayVisibility { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("onAnimEventName")]
public CName OnAnimEventName { get; set;}

#endregion
}
}