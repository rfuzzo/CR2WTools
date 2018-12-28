using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestsSystem : IGameSystem
{
#region RED Properties

[REDProp("runningQuests")]
public Array<Handle<CQuest>> RunningQuests { get; set;}

#endregion
}
}