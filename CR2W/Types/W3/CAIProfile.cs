using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAIProfile : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("reactions")]
public Array<Handle<CAIReaction>> Reactions { get; set;}

[REDProp("senseVisionParams")]
public Ptr<CAISenseParams> SenseVisionParams { get; set;}

[REDProp("senseAbsoluteParams")]
public Ptr<CAISenseParams> SenseAbsoluteParams { get; set;}

[REDProp("attitudeGroup")]
public CName AttitudeGroup { get; set;}

[REDProp("minigameParams")]
public SAIMinigameParams MinigameParams { get; set;}

#endregion
}
}