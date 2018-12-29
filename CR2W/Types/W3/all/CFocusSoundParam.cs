using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFocusSoundParam : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("eventStart")]
public CName EventStart { get; set;}

[REDProp("eventStop")]
public CName EventStop { get; set;}

[REDProp("hearingAngle")]
public float HearingAngle { get; set;}

[REDProp("visualEffectBoneName")]
public CName VisualEffectBoneName { get; set;}

#endregion
}
}