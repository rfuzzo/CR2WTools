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
public class CMenuResource : IGuiResource
{
#region RED Properties

[REDProp("resourceBlocks")]
public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set;}

[REDProp("menuClass")]
public CName MenuClass { get; set;}

[REDProp("menuFlashSwf")]
public Soft<CSwfResource> MenuFlashSwf { get; set;}

[REDProp("layer")]
public int Layer { get; set;}

[REDProp("menuDef")]
public Ptr<CMenuDef> MenuDef { get; set;}

#endregion
}
}