using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationInterceptorStateAbstract : CExplorationStateTransitionAbstract
{
#region RED Properties

[REDProp("m_InterceptStateN")]
public CName M_InterceptStateN { get; set;}

#endregion
}
}