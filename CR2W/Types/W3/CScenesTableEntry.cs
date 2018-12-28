using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CScenesTableEntry 
{
#region RED Properties

[REDProp("sceneFile")]
public Soft<CStoryScene> SceneFile { get; set;}

[REDProp("sceneInput")]
public string SceneInput { get; set;}

[REDProp("requiredFact")]
public string RequiredFact { get; set;}

[REDProp("forbiddenFact")]
public string ForbiddenFact { get; set;}

#endregion
}
}