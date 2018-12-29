using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskGetFoodNearby : IBehTreeTask
{
#region RED Properties

[REDProp("foodToLookFor")]
public Int32 FoodToLookFor { get; set;}

[REDProp("completeIfTargetChange")]
public bool CompleteIfTargetChange { get; set;}

[REDProp("m_foodFound")]
public Handle<W3FoodComponent> M_foodFound { get; set;}

[REDProp("m_scentFound")]
public Handle<W3ScentComponent> M_scentFound { get; set;}

[REDProp("m_alreadyTrackedScents")]
public Array<Handle<W3ScentComponent>> M_alreadyTrackedScents { get; set;}

[REDProp("m_timeAtLastCheck")]
public float M_timeAtLastCheck { get; set;}

[REDProp("m_delayBetweenChecks")]
public float M_delayBetweenChecks { get; set;}

[REDProp("m_WasFalse")]
public bool M_WasFalse { get; set;}

[REDProp("m_EntitiesAround")]
public Array<Handle<CGameplayEntity>> M_EntitiesAround { get; set;}

[REDProp("m_delayBetweenUpdateEntities")]
public float M_delayBetweenUpdateEntities { get; set;}

[REDProp("m_timeAtLastUpdateEntities")]
public float M_timeAtLastUpdateEntities { get; set;}

#endregion
}
}