using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class Box 
{
#region RED Properties

[REDProp("Min")]
public Vector Min { get; set;}

[REDProp("Max")]
public Vector Max { get; set;}

#endregion
}
}