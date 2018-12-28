using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestPhaseBlock : CQuestScopeBlock
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

[REDProp("layersToLoad")]
public Array<string> LayersToLoad { get; set;}

[REDProp("isBlackscreenPhase")]
public bool IsBlackscreenPhase { get; set;}

[REDProp("blackscreenFadeDuration")]
public float BlackscreenFadeDuration { get; set;}

[REDProp("saveMode")]
public EQuestPhaseSaveMode SaveMode { get; set;}

[REDProp("soundBanksDependency")]
public Array<CName> SoundBanksDependency { get; set;}

[REDProp("playGoChunk")]
public CName PlayGoChunk { get; set;}

[REDProp("purgeSavedData")]
public bool PurgeSavedData { get; set;}

#endregion
}
}