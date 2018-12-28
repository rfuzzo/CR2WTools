using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SReactionSceneEvent 
{
#region RED Properties

[REDProp("reactionScene")]
public CName ReactionScene { get; set;}

[REDProp("requiredSceneInputs")]
public Array<string> RequiredSceneInputs { get; set;}

[REDProp("inputsAsymetric")]
public bool InputsAsymetric { get; set;}

[REDProp("workOnlyBroadcast")]
public bool WorkOnlyBroadcast { get; set;}

#endregion
}
}