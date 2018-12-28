using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestBehaviorCtrlBlock : CQuestScopeBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("forceKeepLoadingScreen")]
public bool ForceKeepLoadingScreen { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("cachedConnections")]
public Array<SCachedConnections> CachedConnections { get; set;}

[REDProp("hasPatchOutput")]
public bool HasPatchOutput { get; set;}

[REDProp("hasTerminationInput")]
public bool HasTerminationInput { get; set;}

[REDProp("phase")]
public Handle<CQuestPhase> Phase { get; set;}

[REDProp("embeddedGraph")]
public Ptr<CQuestGraph> EmbeddedGraph { get; set;}

[REDProp("phaseHandle")]
public Soft<CQuestPhase> PhaseHandle { get; set;}

[REDProp("requiredWorld")]
public string RequiredWorld { get; set;}

[REDProp("saveMode")]
public EQuestBehaviorSceneSaveMode SaveMode { get; set;}

[REDProp("activationTimeout")]
public float ActivationTimeout { get; set;}

[REDProp("groups")]
public Array<Ptr<SBehaviorGroup>> Groups { get; set;}

#endregion
}
}