using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFXTrackItemPlayItemEffect : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("category")]
public CName Category { get; set;}

[REDProp("itemName_optional")]
public CName ItemName_optional { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

#endregion
}
}