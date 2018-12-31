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
public class SHudDescription 
{
#region RED Properties

[REDProp("hudName")]
public CName HudName { get; set;}

[REDProp("hudResource")]
public Soft<CHudResource> HudResource { get; set;}

#endregion
}
}