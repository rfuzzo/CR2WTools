using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMutationsUnlockedSkillSlot : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("LEVEL_UP")]
public CName LEVEL_UP { get; set;}

[REDProp("OPEN_CHAR_PANEL")]
public CName OPEN_CHAR_PANEL { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("selectedMutation")]
public EPlayerMutationType SelectedMutation { get; set;}

#endregion
}
}