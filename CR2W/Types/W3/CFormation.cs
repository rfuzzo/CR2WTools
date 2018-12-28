using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormation : CResource
{
#region RED Properties

[REDProp("uniqueFormationName")]
public CName UniqueFormationName { get; set;}

[REDProp("formationLogic")]
public Ptr<IFormationLogic> FormationLogic { get; set;}

[REDProp("steeringGraph")]
public Handle<CMoveSteeringBehavior> SteeringGraph { get; set;}

#endregion
}
}