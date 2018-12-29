using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_GlobalAttitude : CQuestScriptedCondition
{
#region RED Properties

[REDProp("srcGroup")]
public CName SrcGroup { get; set;}

[REDProp("dstGroup")]
public CName DstGroup { get; set;}

[REDProp("attitude")]
public EAIAttitude Attitude { get; set;}

#endregion
}
}