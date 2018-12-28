using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSceneChoice 
{
#region RED Properties

[REDProp("description")]
public string Description { get; set;}

[REDProp("emphasised")]
public bool Emphasised { get; set;}

[REDProp("previouslyChoosen")]
public bool PreviouslyChoosen { get; set;}

[REDProp("disabled")]
public bool Disabled { get; set;}

[REDProp("dialogAction")]
public EDialogActionIcon DialogAction { get; set;}

[REDProp("playGoChunk")]
public CName PlayGoChunk { get; set;}

#endregion
}
}