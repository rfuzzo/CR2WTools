using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSteeringCompositeCondition : IMoveSteeringCondition
{
#region RED Properties

[REDProp("firstCondition")]
public Ptr<IMoveSteeringCondition> FirstCondition { get; set;}

[REDProp("notFirstCondition")]
public bool NotFirstCondition { get; set;}

[REDProp("operator")]
public ELogicOperator Operator { get; set;}

[REDProp("secondCondition")]
public Ptr<IMoveSteeringCondition> SecondCondition { get; set;}

[REDProp("notSecondCondition")]
public bool NotSecondCondition { get; set;}

#endregion
}
}