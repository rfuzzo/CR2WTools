using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IAIExplorationTree : IAITree
{
#region RED Properties

[REDProp("aiTreeName")]
public string AiTreeName { get; set;}

[REDProp("tree")]
public Handle<CBehTree> Tree { get; set;}

[REDProp("interactionPoint")]
public Vector3 InteractionPoint { get; set;}

[REDProp("destinationPoint")]
public Vector3 DestinationPoint { get; set;}

[REDProp("metalinkComponent")]
public Handle<CComponent> MetalinkComponent { get; set;}

#endregion
}
}