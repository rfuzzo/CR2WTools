using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateCharacterDevelopment : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("OPEN_CHAR_DEV")]
public CName OPEN_CHAR_DEV { get; set;}

[REDProp("LEVELING")]
public CName LEVELING { get; set;}

[REDProp("SKILLS")]
public CName SKILLS { get; set;}

[REDProp("BUY_SKILL")]
public CName BUY_SKILL { get; set;}

[REDProp("SKILL_EQUIPPING")]
public CName SKILL_EQUIPPING { get; set;}

[REDProp("EQUIP_SKILL")]
public CName EQUIP_SKILL { get; set;}

[REDProp("SKILL_UNEQUIPPING")]
public CName SKILL_UNEQUIPPING { get; set;}

[REDProp("GROUPS")]
public CName GROUPS { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}