using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestCutsceneCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("cutsceneName")]
public string CutsceneName { get; set;}

[REDProp("event")]
public CName Event { get; set;}

#endregion
}
}