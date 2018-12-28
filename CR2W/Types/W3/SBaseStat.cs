using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBaseStat 
{
#region RED Properties

[REDProp("current")]
public float Current { get; set;}

[REDProp("max")]
public float Max { get; set;}

[REDProp("type")]
public EBaseCharacterStats Type { get; set;}

#endregion
}
}