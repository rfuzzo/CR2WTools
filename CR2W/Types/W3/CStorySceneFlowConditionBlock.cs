using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneFlowConditionBlock : CStorySceneGraphBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("description")]
public string Description { get; set;}

[REDProp("condition")]
public Ptr<CStorySceneFlowCondition> Condition { get; set;}

#endregion
}
}