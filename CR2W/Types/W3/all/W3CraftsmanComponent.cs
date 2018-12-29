using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CraftsmanComponent : W3MerchantComponent
{
#region RED Properties

[REDProp("craftsmanData")]
public Array<SCraftsman> CraftsmanData { get; set;}

#endregion
}
}