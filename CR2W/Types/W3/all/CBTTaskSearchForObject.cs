using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSearchForObject : IBehTreeTask
{
#region RED Properties

[REDProp("range")]
public float Range { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("selectRandomObject")]
public bool SelectRandomObject { get; set;}

[REDProp("avoidSelectingPreviousOne")]
public bool AvoidSelectingPreviousOne { get; set;}

[REDProp("dontSelectClosestOneIfPossible")]
public bool DontSelectClosestOneIfPossible { get; set;}

[REDProp("addFactOnLastObject")]
public bool AddFactOnLastObject { get; set;}

[REDProp("setActionTargetOnIsAvailable")]
public bool SetActionTargetOnIsAvailable { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("selectedObject")]
public Handle<CNode> SelectedObject { get; set;}

[REDProp("previouslySelectedObject")]
public Handle<CGameplayEntity> PreviouslySelectedObject { get; set;}

[REDProp("searchTimeStamp")]
public float SearchTimeStamp { get; set;}

#endregion
}
}