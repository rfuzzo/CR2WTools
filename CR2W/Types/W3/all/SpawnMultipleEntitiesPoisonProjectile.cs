using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SpawnMultipleEntitiesPoisonProjectile : PoisonProjectile
{
#region RED Properties

[REDProp("numberOfSpawns")]
public Int32 NumberOfSpawns { get; set;}

[REDProp("minDistFromTarget")]
public Int32 MinDistFromTarget { get; set;}

[REDProp("maxDistFromTarget")]
public Int32 MaxDistFromTarget { get; set;}

#endregion
}
}