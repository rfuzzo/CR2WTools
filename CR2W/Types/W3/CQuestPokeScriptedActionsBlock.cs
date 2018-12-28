using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestPokeScriptedActionsBlock : CQuestGraphBlock
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

[REDProp("npcTag")]
public CName NpcTag { get; set;}

[REDProp("pokeEvent")]
public CName PokeEvent { get; set;}

[REDProp("handleBehaviorOutcome")]
public bool HandleBehaviorOutcome { get; set;}

[REDProp("onlyOneActor")]
public bool OnlyOneActor { get; set;}

#endregion
}
}