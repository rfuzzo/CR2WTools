using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPopupResource : IGuiResource
{
#region RED Properties

[REDProp("resourceBlocks")]
public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set;}

[REDProp("popupClass")]
public CName PopupClass { get; set;}

[REDProp("popupFlashSwf")]
public Soft<CSwfResource> PopupFlashSwf { get; set;}

[REDProp("layer")]
public int Layer { get; set;}

[REDProp("popupDef")]
public Ptr<CPopupDef> PopupDef { get; set;}

#endregion
}
}