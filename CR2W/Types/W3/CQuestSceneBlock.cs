using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestSceneBlock : CQuestGraphBlock
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

[REDProp("scene")]
public Soft<CStoryScene> Scene { get; set;}

[REDProp("forcingMode")]
public EStorySceneForcingMode ForcingMode { get; set;}

[REDProp("forceSpawnedActors")]
public bool ForceSpawnedActors { get; set;}

[REDProp("interrupt")]
public bool Interrupt { get; set;}

[REDProp("shouldFadeOnLoading")]
public bool ShouldFadeOnLoading { get; set;}

[REDProp("shouldFadeOnLoading_NamesCooked")]
public Array<CName> ShouldFadeOnLoading_NamesCooked { get; set;}

[REDProp("shouldFadeOnLoading_ValuesCooked")]
public Array<bool> ShouldFadeOnLoading_ValuesCooked { get; set;}

[REDProp("saveMode")]
public EQuestSceneSaveMode SaveMode { get; set;}

[REDProp("saveSkipOutputNode")]
public CName SaveSkipOutputNode { get; set;}

[REDProp("playGoChunk")]
public CName PlayGoChunk { get; set;}

#endregion
}
}