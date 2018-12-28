using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneActorTemplate 
{
#region RED Properties

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("appearances")]
public Array<CName> Appearances { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

#endregion
}
}