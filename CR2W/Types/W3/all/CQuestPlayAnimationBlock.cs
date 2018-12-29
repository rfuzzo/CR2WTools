using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQuestPlayAnimationBlock : CQuestGraphBlock
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

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("operation")]
public EPropertyAnimationOperation Operation { get; set;}

[REDProp("playCount")]
public uint PlayCount { get; set;}

[REDProp("playLengthScale")]
public float PlayLengthScale { get; set;}

[REDProp("playPropertyCurveMode")]
public EPropertyCurveMode PlayPropertyCurveMode { get; set;}

[REDProp("rewindTime")]
public float RewindTime { get; set;}

#endregion
}
}