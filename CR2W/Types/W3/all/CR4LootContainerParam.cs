using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4LootContainerParam 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("chance")]
public float Chance { get; set;}

[REDProp("respawnTime")]
public uint RespawnTime { get; set;}

#endregion
}
}