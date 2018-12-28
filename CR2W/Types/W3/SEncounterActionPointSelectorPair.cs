using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SEncounterActionPointSelectorPair 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("chance")]
public float Chance { get; set;}

#endregion
}
}