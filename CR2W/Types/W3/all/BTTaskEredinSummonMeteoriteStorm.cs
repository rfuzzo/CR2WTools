using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskEredinSummonMeteoriteStorm : IBehTreeTask
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("shouldSpawn")]
public bool ShouldSpawn { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

#endregion
}
}