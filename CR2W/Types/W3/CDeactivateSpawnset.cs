using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDeactivateSpawnset : IQuestSpawnsetAction
{
#region RED Properties

[REDProp("spawnset")]
public Handle<CCommunity> Spawnset { get; set;}

#endregion
}
}