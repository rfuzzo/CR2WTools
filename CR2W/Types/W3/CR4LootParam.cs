using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4LootParam : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("containers")]
public Array<CR4LootContainerParam> Containers { get; set;}

[REDProp("usedContainersMin")]
public uint UsedContainersMin { get; set;}

[REDProp("usedContainersMax")]
public uint UsedContainersMax { get; set;}

[REDProp("alwaysPresent")]
public bool AlwaysPresent { get; set;}

#endregion
}
}