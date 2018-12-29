using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeDecoratorGlideDefinition : IBehTreeNodeFlightDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("minChangeDelay")]
public float MinChangeDelay { get; set;}

[REDProp("glideChance")]
public float GlideChance { get; set;}

[REDProp("stopGlideChance")]
public float StopGlideChance { get; set;}

#endregion
}
}