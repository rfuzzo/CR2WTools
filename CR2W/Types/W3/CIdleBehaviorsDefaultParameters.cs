using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CIdleBehaviorsDefaultParameters : IAISpawnTreeSubParameters
{
#region RED Properties

[REDProp("actionPointsArea")]
public EntityHandle ActionPointsArea { get; set;}

[REDProp("wanderArea")]
public EntityHandle WanderArea { get; set;}

[REDProp("wanderPointsTag")]
public CName WanderPointsTag { get; set;}

#endregion
}
}