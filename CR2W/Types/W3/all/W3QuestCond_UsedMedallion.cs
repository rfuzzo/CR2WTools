using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_UsedMedallion : CQuestScriptedCondition
{
#region RED Properties

[REDProp("medallion")]
public Handle<W3MedallionController> Medallion { get; set;}

#endregion
}
}