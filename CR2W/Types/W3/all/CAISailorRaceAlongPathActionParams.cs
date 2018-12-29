using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAISailorRaceAlongPathActionParams : ISailorActionParameters
{
#region RED Properties

[REDProp("boatTag")]
public CName BoatTag { get; set;}

[REDProp("pathTag")]
public CName PathTag { get; set;}

[REDProp("upThePath")]
public bool UpThePath { get; set;}

[REDProp("startFromBeginning")]
public bool StartFromBeginning { get; set;}

#endregion
}
}