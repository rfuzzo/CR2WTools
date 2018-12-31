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
public class CMenuDef : CObject
{
#region RED Properties

[REDProp("timeParam")]
public Ptr<IMenuTimeParam> TimeParam { get; set;}

[REDProp("backgroundVideoParam")]
public Ptr<IMenuBackgroundVideoParam> BackgroundVideoParam { get; set;}

[REDProp("renderParam")]
public Ptr<IMenuDisplayParam> RenderParam { get; set;}

#endregion
}
}