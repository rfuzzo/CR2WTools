using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondIsInBehaviorGraphNode : IBehTreeTask
{
#region RED Properties

[REDProp("activationScriptEvent")]
public CName ActivationScriptEvent { get; set;}

[REDProp("deactivateScriptEvent")]
public CName DeactivateScriptEvent { get; set;}

[REDProp("m_availability")]
public bool M_availability { get; set;}

#endregion
}
}