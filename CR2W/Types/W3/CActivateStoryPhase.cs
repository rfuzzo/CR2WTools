using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CActivateStoryPhase : IQuestSpawnsetAction
{
#region RED Properties

[REDProp("spawnset")]
public Soft<CCommunity> Spawnset { get; set;}

[REDProp("phase")]
public CName Phase { get; set;}

[REDProp("streamingPartition")]
public string StreamingPartition { get; set;}

#endregion
}
}