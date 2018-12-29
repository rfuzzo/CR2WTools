using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeDecoratorCluePathDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("clueTemplate")]
public Handle<CEntityTemplate> ClueTemplate { get; set;}

[REDProp("clueTemplate_var")]
public CName ClueTemplate_var { get; set;}

[REDProp("maxClues")]
public CBehTreeValInt MaxClues { get; set;}

[REDProp("cluesOffset")]
public CBehTreeValFloat CluesOffset { get; set;}

#endregion
}
}