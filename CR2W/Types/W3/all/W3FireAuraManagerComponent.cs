using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FireAuraManagerComponent : CR4Component
{
#region RED Properties

[REDProp("fireAuraEffect")]
public CName FireAuraEffect { get; set;}

[REDProp("m_PostFxOnGroundCmp")]
public Handle<W3PostFXOnGroundComponent> M_PostFxOnGroundCmp { get; set;}

#endregion
}
}