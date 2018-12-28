using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class StorySceneDefinition 
{
#region RED Properties

[REDProp("scene")]
public Soft<CStoryScene> Scene { get; set;}

[REDProp("input")]
public CName Input { get; set;}

#endregion
}
}