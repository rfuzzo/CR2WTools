using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SItemStat 
{
#region RED Properties

[REDProp("statType")]
public CName StatType { get; set;}

[REDProp("statWeight")]
public float StatWeight { get; set;}

[REDProp("statIsPercentage")]
public bool StatIsPercentage { get; set;}

#endregion
}
}