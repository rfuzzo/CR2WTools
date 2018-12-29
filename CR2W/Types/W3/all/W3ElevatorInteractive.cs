using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ElevatorInteractive : W3Elevator
{
#region RED Properties

[REDProp("initialPosOnTop")]
public bool InitialPosOnTop { get; set;}

[REDProp("targetObject")]
public EntityHandle TargetObject { get; set;}

[REDProp("maxHeight")]
public float MaxHeight { get; set;}

[REDProp("mechanismEntityHandle")]
public EntityHandle MechanismEntityHandle { get; set;}

[REDProp("interactionComponent")]
public Handle<CInteractionComponent> InteractionComponent { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("explorationComponents")]
public Array<Handle<CComponent>> ExplorationComponents { get; set;}

[REDProp("switches")]
public Array<Handle<W3ElevatorSwitch>> Switches { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("size")]
public Int32 Size { get; set;}

[REDProp("elevatorSaveLockInt")]
public Int32 ElevatorSaveLockInt { get; set;}

#endregion
}
}