using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSeedKeyValue 
{
#region RED Properties

[REDProp("key")]
public uint Key { get; set;}

[REDProp("val")]
public uint Val { get; set;}

#endregion
}
}