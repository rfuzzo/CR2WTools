using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EnchantmentManager : CObject
{
#region RED Properties

[REDProp("schematics")]
public Array<SEnchantmentSchematic> Schematics { get; set;}

[REDProp("craftMasterComp")]
public Handle<W3CraftsmanComponent> CraftMasterComp { get; set;}

[REDProp("schematicsNames")]
public Array<CName> SchematicsNames { get; set;}

#endregion
}
}