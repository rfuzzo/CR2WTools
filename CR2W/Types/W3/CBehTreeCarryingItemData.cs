using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeCarryingItemData 
{
#region RED Properties

[REDProp("carriedItem")]
public Handle<CEntity> CarriedItem { get; set;}

#endregion
}
}