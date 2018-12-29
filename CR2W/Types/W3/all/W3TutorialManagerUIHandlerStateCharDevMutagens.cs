using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateCharDevMutagens : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("SELECT_TAB")]
public CName SELECT_TAB { get; set;}

[REDProp("EQUIP")]
public CName EQUIP { get; set;}

[REDProp("BONUSES")]
public CName BONUSES { get; set;}

[REDProp("MATCH_SKILL_COLOR")]
public CName MATCH_SKILL_COLOR { get; set;}

[REDProp("MULTIPLE_SKILLS")]
public CName MULTIPLE_SKILLS { get; set;}

[REDProp("WRONG_COLOR")]
public CName WRONG_COLOR { get; set;}

[REDProp("POTIONS")]
public CName POTIONS { get; set;}

[REDProp("MUTAGENS_JOURNAL")]
public CName MUTAGENS_JOURNAL { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("savedEquippedSkills")]
public Array<STutorialSavedSkill> SavedEquippedSkills { get; set;}

#endregion
}
}