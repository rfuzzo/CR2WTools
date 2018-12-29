using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IBehTreeTaskProcessProjectileDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("destroyProjectileOnDeactivate")]
public bool DestroyProjectileOnDeactivate { get; set;}

[REDProp("projTemplate")]
public Handle<CEntityTemplate> ProjTemplate { get; set;}

#endregion
}
}