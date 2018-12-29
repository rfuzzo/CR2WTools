using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DialogueMonsterBarganingSliderData : DialogueSliderData
{
#region RED Properties

[REDProp("baseValue")]
public Int32 BaseValue { get; set;}

[REDProp("anger")]
public float Anger { get; set;}

[REDProp("alternativeRewardType")]
public bool AlternativeRewardType { get; set;}

#endregion
}
}