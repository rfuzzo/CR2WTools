using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FocusModeEffectIntensity : CObject
{
#region RED Properties

[REDProp("chooseEntityStrategy")]
public EFocusModeChooseEntityStrategy ChooseEntityStrategy { get; set;}

[REDProp("bestEntity")]
public Handle<CEntity> BestEntity { get; set;}

[REDProp("bestDistance")]
public float BestDistance { get; set;}

[REDProp("lastDistance")]
public float LastDistance { get; set;}

[REDProp("bestIntensity")]
public float BestIntensity { get; set;}

[REDProp("lastIntensity")]
public float LastIntensity { get; set;}

#endregion
}
}