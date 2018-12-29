using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DifficultyChangeConfirmation : ConfirmationPopupData
{
#region RED Properties

[REDProp("menuRef")]
public Handle<CR4IngameMenu> MenuRef { get; set;}

[REDProp("targetDifficulty")]
public Int32 TargetDifficulty { get; set;}

#endregion
}
}