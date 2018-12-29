using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3RefillableContainer : W3Container
{
#region RED Properties

[REDProp("isEmpty")]
public bool IsEmpty { get; set;}

[REDProp("checkedForBonusHerbs")]
public bool CheckedForBonusHerbs { get; set;}

#endregion
}
}