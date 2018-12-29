using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SWorldDescription 
{
#region RED Properties

[REDProp("worldName")]
public LocalizedString WorldName { get; set;}

[REDProp("world")]
public Soft<CWorld> World { get; set;}

#endregion
}
}