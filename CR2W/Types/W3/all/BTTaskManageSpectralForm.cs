using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageSpectralForm : IBehTreeTask
{
#region RED Properties

[REDProp("m_LastEnteredYrden")]
public Handle<W3YrdenEntity> M_LastEnteredYrden { get; set;}

[REDProp("m_IsInYrden")]
public bool M_IsInYrden { get; set;}

#endregion
}
}