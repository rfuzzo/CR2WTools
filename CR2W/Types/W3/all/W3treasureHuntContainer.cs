using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3treasureHuntContainer : W3Container
{
#region RED Properties

[REDProp("OnLootedEvents")]
public Array<Handle<W3SwitchEvent>> OnLootedEvents { get; set;}

#endregion
}
}