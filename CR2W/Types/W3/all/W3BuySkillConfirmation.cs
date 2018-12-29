using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BuySkillConfirmation : ConfirmationPopupData
{
#region RED Properties

[REDProp("characterMenuRef")]
public Handle<CR4CharacterMenu> CharacterMenuRef { get; set;}

[REDProp("targetSkill")]
public ESkill TargetSkill { get; set;}

#endregion
}
}