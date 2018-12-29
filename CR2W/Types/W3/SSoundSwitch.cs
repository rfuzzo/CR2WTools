using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SSoundSwitch 
{
#region RED Properties

[REDProp("SoundSwitch")]
public StringAnsi SoundSwitch { get; set;}

[REDProp("value")]
public StringAnsi Value { get; set;}

#endregion
}
}