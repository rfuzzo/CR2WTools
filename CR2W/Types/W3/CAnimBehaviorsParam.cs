using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimBehaviorsParam : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("componentName")]
public string ComponentName { get; set;}

[REDProp("slots")]
public Array<SBehaviorGraphInstanceSlot> Slots { get; set;}

#endregion
}
}