using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SResistanceValue 
{
#region RED Properties

[REDProp("points")]
public SAbilityAttributeValue Points { get; set;}

[REDProp("percents")]
public SAbilityAttributeValue Percents { get; set;}

[REDProp("type")]
public ECharacterDefenseStats Type { get; set;}

#endregion
}
}