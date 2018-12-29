using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskNpcRider : IBehTreeTask
{
#region RED Properties

[REDProp("activate")]
public bool Activate { get; set;}

[REDProp("horseComponent")]
public Handle<W3HorseComponent> HorseComponent { get; set;}

[REDProp("riderEntity")]
public Handle<CActor> RiderEntity { get; set;}

#endregion
}
}