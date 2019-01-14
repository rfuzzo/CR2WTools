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
public class SSeedKeyValue 
{
#region RED Properties

[REDProp("key")]
public UInt32 Key { get; set;}

[REDProp("val")]
public UInt32 Val { get; set;}

#endregion
}
}