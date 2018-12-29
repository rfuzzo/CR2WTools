using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskElementalThrow : IBehTreeTask
{
#region RED Properties

[REDProp("physicalComponent")]
public Handle<CMeshComponent> PhysicalComponent { get; set;}

[REDProp("objectEntity")]
public Handle<CEntityTemplate> ObjectEntity { get; set;}

[REDProp("object")]
public Handle<CEntity> Object { get; set;}

#endregion
}
}