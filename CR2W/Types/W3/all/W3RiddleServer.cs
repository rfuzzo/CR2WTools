using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3RiddleServer : CGameplayEntity
{
#region RED Properties

[REDProp("OnGoodCombinationEvents")]
public Array<Handle<W3SwitchEvent>> OnGoodCombinationEvents { get; set;}

[REDProp("pairedNodes")]
public Array<EntityHandle> PairedNodes { get; set;}

[REDProp("riddleNodesNumber")]
public Int32 RiddleNodesNumber { get; set;}

[REDProp("isDisabled")]
public bool IsDisabled { get; set;}

[REDProp("nodesAtValidPosNumber")]
public Int32 NodesAtValidPosNumber { get; set;}

#endregion
}
}