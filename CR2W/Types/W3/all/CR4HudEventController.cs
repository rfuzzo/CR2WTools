using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudEventController : CObject
{
#region RED Properties

[REDProp("delayedEvents")]
public Array<Handle<CHudEvent>> DelayedEvents { get; set;}

#endregion
}
}