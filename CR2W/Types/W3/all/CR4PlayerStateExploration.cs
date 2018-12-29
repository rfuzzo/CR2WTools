using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateExploration : CR4PlayerStateExtendedMovable
{
#region RED Properties

[REDProp("wantsToSheatheWeapon")]
public bool WantsToSheatheWeapon { get; set;}

[REDProp("m_lastUsedPCInput")]
public bool M_lastUsedPCInput { get; set;}

[REDProp("cachedPos")]
public Vector CachedPos { get; set;}

[REDProp("constDamper")]
public Handle<ConstDamper> ConstDamper { get; set;}

#endregion
}
}