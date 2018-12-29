using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMutationsCharPanelUnlockedSkillSlot : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("ADDITIONAL_SLOT")]
public CName ADDITIONAL_SLOT { get; set;}

[REDProp("COLOR")]
public CName COLOR { get; set;}

[REDProp("YELLOW")]
public CName YELLOW { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("selectedMutation")]
public EPlayerMutationType SelectedMutation { get; set;}

#endregion
}
}