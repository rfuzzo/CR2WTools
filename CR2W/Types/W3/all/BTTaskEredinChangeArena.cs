using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskEredinChangeArena : IBehTreeTask
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("spawnPortalInTaggedNode")]
public bool SpawnPortalInTaggedNode { get; set;}

[REDProp("nodeTag")]
public CName NodeTag { get; set;}

[REDProp("destinationTag")]
public CName DestinationTag { get; set;}

[REDProp("factOnPlayerTeleport")]
public string FactOnPlayerTeleport { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("shouldCreateRift")]
public bool ShouldCreateRift { get; set;}

#endregion
}
}