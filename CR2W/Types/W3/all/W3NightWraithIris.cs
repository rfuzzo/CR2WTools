using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NightWraithIris : CNewNPC
{
#region RED Properties

[REDProp("m_CurrentHealthSection")]
public Int32 M_CurrentHealthSection { get; set;}

[REDProp("m_ClosestPainting")]
public Handle<CNode> M_ClosestPainting { get; set;}

[REDProp("m_TargetPainting")]
public Handle<W3IrisPainting> M_TargetPainting { get; set;}

[REDProp("m_Paintings")]
public Array<Handle<CNode>> M_Paintings { get; set;}

[REDProp("m_WaitingForSpawnEnd")]
public bool M_WaitingForSpawnEnd { get; set;}

#endregion
}
}