using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SItemDamageCurve 
{
#region RED Properties

[REDProp("term1")]
public float Term1 { get; set;}

[REDProp("term2")]
public float Term2 { get; set;}

[REDProp("term3")]
public float Term3 { get; set;}

#endregion
}
}