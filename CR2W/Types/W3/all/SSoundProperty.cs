using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSoundProperty 
{
#region RED Properties

[REDProp("SoundProperty")]
public StringAnsi SoundProperty { get; set;}

[REDProp("value")]
public float Value { get; set;}

#endregion
}
}