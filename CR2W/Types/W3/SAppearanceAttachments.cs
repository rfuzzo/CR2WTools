using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SAppearanceAttachments 
{
#region RED Properties

[REDProp("appearance")]
public CName Appearance { get; set;}

[REDProp("attachments")]
public Array<SAppearanceAttachment> Attachments { get; set;}

#endregion
}
}