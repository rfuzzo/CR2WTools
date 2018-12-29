using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskIrisRequestPortal : IBehTreeTask
{
#region RED Properties

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onAnimEvent")]
public CName OnAnimEvent { get; set;}

[REDProp("m_Npc")]
public Handle<W3NightWraithIris> M_Npc { get; set;}

#endregion
}
}