using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CScriptedAnimEventsListenerComponent : CScriptedComponent
{
#region RED Properties

[REDProp("listeners")]
public Array<Handle<CComponent>> Listeners { get; set;}

#endregion
}
}