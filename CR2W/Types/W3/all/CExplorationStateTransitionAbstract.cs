using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateTransitionAbstract : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_TransitionOriginStateN")]
public CName M_TransitionOriginStateN { get; set;}

[REDProp("m_TransitionEndStateN")]
public CName M_TransitionEndStateN { get; set;}

#endregion
}
}