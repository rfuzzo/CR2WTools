using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAnimalCombatHorse : CAIAnimalCombat
{
#region RED Properties

[REDProp("shakeRiderTree")]
public Handle<CAIHorseShakeRider> ShakeRiderTree { get; set;}

#endregion
}
}