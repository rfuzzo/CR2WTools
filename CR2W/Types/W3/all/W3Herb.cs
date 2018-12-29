using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Herb : W3RefillableContainer
{
#region RED Properties

[REDProp("foliageComponent")]
public Handle<CSwitchableFoliageComponent> FoliageComponent { get; set;}

[REDProp("isEmptyAppearance")]
public bool IsEmptyAppearance { get; set;}

#endregion
}
}