using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneChoiceLineActionScriptedContentGuard : CStorySceneChoiceLineActionScripted
{
#region RED Properties

[REDProp("playGoChunk")]
public CName PlayGoChunk { get; set;}

#endregion
}
}