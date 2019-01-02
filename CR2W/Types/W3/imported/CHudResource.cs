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
public class CHudResource : IGuiResource
{
#region RED Properties

[REDProp("resourceBlocks", 2,0)]
public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set;}

[REDProp("hudClass")]
public CName HudClass { get; set;}

[REDProp("hudFlashSwf")]
public Soft<CSwfResource> HudFlashSwf { get; set;}

#endregion
}
}