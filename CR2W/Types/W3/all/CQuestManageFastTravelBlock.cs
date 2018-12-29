using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQuestManageFastTravelBlock : CQuestGraphBlock
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

[REDProp("operation")]
public EQuestManageFastTravelOperation Operation { get; set;}

[REDProp("enable")]
public bool Enable { get; set;}

[REDProp("show")]
public bool Show { get; set;}

[REDProp("affectedAreas")]
public Array<Int32> AffectedAreas { get; set;}

[REDProp("affectedFastTravelPoints")]
public Array<CName> AffectedFastTravelPoints { get; set;}

#endregion
}
}