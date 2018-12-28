using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class Quad 
{
#region RED Properties

[REDProp("p1")]
public Vector P1 { get; set;}

[REDProp("p2")]
public Vector P2 { get; set;}

[REDProp("p3")]
public Vector P3 { get; set;}

[REDProp("p4")]
public Vector P4 { get; set;}

#endregion
}
}