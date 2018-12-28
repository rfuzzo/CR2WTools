using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormationSlotDefinition 
{
#region RED Properties

[REDProp("constraints")]
public Array<SFormationConstraintDefinition> Constraints { get; set;}

#endregion
}
}