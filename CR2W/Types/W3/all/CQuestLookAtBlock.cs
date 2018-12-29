using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQuestLookAtBlock : CQuestGraphBlock
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

[REDProp("actor")]
public CName Actor { get; set;}

[REDProp("target")]
public CName Target { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("type")]
public EDialogLookAtType Type { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("canCloseEyes")]
public bool CanCloseEyes { get; set;}

[REDProp("forceCloseEyes")]
public bool ForceCloseEyes { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("level")]
public ELookAtLevel Level { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("gameplayRange")]
public float GameplayRange { get; set;}

[REDProp("limitDeact")]
public bool LimitDeact { get; set;}

[REDProp("instant")]
public bool Instant { get; set;}

[REDProp("staticPoint")]
public Vector StaticPoint { get; set;}

[REDProp("headRotationRatio")]
public float HeadRotationRatio { get; set;}

[REDProp("eyesLookAtConvergenceWeight")]
public float EyesLookAtConvergenceWeight { get; set;}

[REDProp("eyesLookAtIsAdditive")]
public bool EyesLookAtIsAdditive { get; set;}

[REDProp("eyesLookAtDampScale")]
public float EyesLookAtDampScale { get; set;}

#endregion
}
}