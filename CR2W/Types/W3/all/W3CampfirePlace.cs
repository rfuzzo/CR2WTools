using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CampfirePlace : W3CookingPlace
{
#region RED Properties

[REDProp("victims")]
public Array<Handle<CActor>> Victims { get; set;}

[REDProp("bombs")]
public Array<SItemUniqueId> Bombs { get; set;}

#endregion
}
}