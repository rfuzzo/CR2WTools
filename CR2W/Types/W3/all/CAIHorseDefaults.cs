using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIHorseDefaults : CAIAnimalDefaults
{
#region RED Properties

[REDProp("isMount")]
public bool IsMount { get; set;}

[REDProp("canMoveOutOfAWay")]
public bool CanMoveOutOfAWay { get; set;}

#endregion
}
}