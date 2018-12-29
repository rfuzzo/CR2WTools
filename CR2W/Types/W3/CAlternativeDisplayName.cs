using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAlternativeDisplayName : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("altName")]
public LocalizedString AltName { get; set;}

[REDProp("factID")]
public string FactID { get; set;}

#endregion
}
}