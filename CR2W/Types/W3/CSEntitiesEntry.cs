using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSEntitiesEntry 
{
#region RED Properties

[REDProp("entityTemplate")]
public Soft<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("appearances")]
public Array<CName> Appearances { get; set;}

[REDProp("entitySpawnTags")]
public TagList EntitySpawnTags { get; set;}

[REDProp("mappinTag")]
public CName MappinTag { get; set;}

[REDProp("mappinType")]
public ECommMapPinType MappinType { get; set;}

[REDProp("initializers")]
public Ptr<CCommunityInitializers> Initializers { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("despawners")]
public Ptr<CCommunityInitializers> Despawners { get; set;}

#endregion
}
}