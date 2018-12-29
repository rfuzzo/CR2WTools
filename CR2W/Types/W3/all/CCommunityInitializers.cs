using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCommunityInitializers : CObject
{
#region RED Properties

[REDProp("initializers")]
public Array<Ptr<ISpawnTreeInitializer>> Initializers { get; set;}

#endregion
}
}