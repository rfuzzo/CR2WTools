using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMutationsCanResearch : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SELECT_ADVANCED")]
public CName SELECT_ADVANCED { get; set;}

[REDProp("PREREQUISITES")]
public CName PREREQUISITES { get; set;}

[REDProp("RESEARCHING")]
public CName RESEARCHING { get; set;}

[REDProp("SELECT")]
public CName SELECT { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("selectedMutation")]
public EPlayerMutationType SelectedMutation { get; set;}

#endregion
}
}