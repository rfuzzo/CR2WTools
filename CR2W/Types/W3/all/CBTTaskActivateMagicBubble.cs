using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskActivateMagicBubble : IBehTreeTask
{
#region RED Properties

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("animEventName")]
public CName AnimEventName { get; set;}

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("spawnedEntity")]
public Handle<CEntity> SpawnedEntity { get; set;}

#endregion
}
}