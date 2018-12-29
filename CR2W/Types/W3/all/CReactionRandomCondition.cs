using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CReactionRandomCondition : CReactionScriptedCondition
{
#region RED Properties

[REDProp("percentageChance")]
public Int32 PercentageChance { get; set;}

#endregion
}
}