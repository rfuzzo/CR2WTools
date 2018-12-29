using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionStorage : IBehTreeTask
{
#region RED Properties

[REDProp("reactionDataStorage")]
public Handle<CAIStorageReactionData> ReactionDataStorage { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onCompletion")]
public bool OnCompletion { get; set;}

[REDProp("setIsAlarmed")]
public bool SetIsAlarmed { get; set;}

[REDProp("setTaunted")]
public bool SetTaunted { get; set;}

[REDProp("reset")]
public bool Reset { get; set;}

#endregion
}
}