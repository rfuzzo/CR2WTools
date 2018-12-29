using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_Encounter : W3SwitchEvent
{
#region RED Properties

[REDProp("encounterTag")]
public CName EncounterTag { get; set;}

[REDProp("operation")]
public EEncounterOperation Operation { get; set;}

#endregion
}
}