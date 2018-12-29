using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorGraphInstanceSlot 
{
#region RED Properties

[REDProp("instanceName")]
public CName InstanceName { get; set;}

[REDProp("graph")]
public Handle<CBehaviorGraph> Graph { get; set;}

[REDProp("alwaysOnTopOfStack")]
public bool AlwaysOnTopOfStack { get; set;}

#endregion
}
}