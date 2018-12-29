using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIWildHorseDefaults : CAIHorseDefaults
{
#region RED Properties

[REDProp("isWildHorse")]
public bool IsWildHorse { get; set;}

#endregion
}
}