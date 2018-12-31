using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Color 
{
#region RED Properties

[REDProp("Red")]
public byte Red { get; set;}

[REDProp("Green")]
public byte Green { get; set;}

[REDProp("Blue")]
public byte Blue { get; set;}

[REDProp("Alpha")]
public byte Alpha { get; set;}

#endregion
}
}