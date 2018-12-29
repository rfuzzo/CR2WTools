using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateTest : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_TesMovementParamsS")]
public SPlaneMovementParameters M_TesMovementParamsS { get; set;}

#endregion
}
}