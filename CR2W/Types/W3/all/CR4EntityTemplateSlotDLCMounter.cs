using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4EntityTemplateSlotDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("baseEntityTemplatePath")]
public string BaseEntityTemplatePath { get; set;}

[REDProp("entityTemplatePaths")]
public Array<string> EntityTemplatePaths { get; set;}

[REDProp("entityTemplateSlots")]
public Array<Ptr<EntitySlot>> EntityTemplateSlots { get; set;}

#endregion
}
}