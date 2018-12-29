using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DialogueSliderData : SliderPopupData
{
#region RED Properties

[REDProp("dialogueRef")]
public Handle<CR4HudModuleDialog> DialogueRef { get; set;}

#endregion
}
}