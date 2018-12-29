using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeScriptTicketAlgorithmDefinition : IBehTreeTicketAlgorithmDefinition
{
#region RED Properties

[REDProp("scriptDef")]
public Handle<ITicketAlgorithmScriptDefinition> ScriptDef { get; set;}

[REDProp("importanceMultiplier")]
public CBehTreeValFloat ImportanceMultiplier { get; set;}

#endregion
}
}