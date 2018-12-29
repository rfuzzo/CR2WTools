using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskEnterDrinkingMinigame : IBehTreeTask
{
#region RED Properties

[REDProp("Event")]
public CName Event { get; set;}

[REDProp("OffEvent")]
public CName OffEvent { get; set;}

[REDProp("available")]
public bool Available { get; set;}

#endregion
}
}