using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateUnconscious : CR4PlayerStateExtendedMovable
{
#region RED Properties

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("isUnconscious")]
public bool IsUnconscious { get; set;}

[REDProp("killedByGuard")]
public bool KilledByGuard { get; set;}

[REDProp("killedByElevator")]
public bool KilledByElevator { get; set;}

[REDProp("wasInFFMiniGame")]
public bool WasInFFMiniGame { get; set;}

[REDProp("m_storedInteractionPri")]
public EInteractionPriority M_storedInteractionPri { get; set;}

[REDProp("cachedID")]
public SItemUniqueId CachedID { get; set;}

[REDProp("itemEnt1")]
public Handle<CEntity> ItemEnt1 { get; set;}

[REDProp("itemEnt2")]
public Handle<CEntity> ItemEnt2 { get; set;}

#endregion
}
}