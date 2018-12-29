using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3RiddleNode : CGameplayEntity
{
#region RED Properties

[REDProp("positions")]
public Array<SRiddleNodePositionDef> Positions { get; set;}

[REDProp("riddleServerTag")]
public CName RiddleServerTag { get; set;}

[REDProp("factOnPositionValid")]
public string FactOnPositionValid { get; set;}

[REDProp("useFocusModeHelper")]
public bool UseFocusModeHelper { get; set;}

[REDProp("currentPos")]
public Int32 CurrentPos { get; set;}

[REDProp("rewind")]
public bool Rewind { get; set;}

[REDProp("currentPairedRiddleNodeID")]
public Int32 CurrentPairedRiddleNodeID { get; set;}

[REDProp("currentPairedRiddleNodesIDS")]
public Array<Int32> CurrentPairedRiddleNodesIDS { get; set;}

[REDProp("riddleServer")]
public Handle<W3RiddleServer> RiddleServer { get; set;}

[REDProp("wasAddedToServer")]
public bool WasAddedToServer { get; set;}

[REDProp("lastPosID")]
public Int32 LastPosID { get; set;}

[REDProp("isDisabled")]
public bool IsDisabled { get; set;}

[REDProp("isEffectOn")]
public bool IsEffectOn { get; set;}

[REDProp("isOnValidPosition")]
public bool IsOnValidPosition { get; set;}

[REDProp("initializeServerCounter")]
public Int32 InitializeServerCounter { get; set;}

#endregion
}
}