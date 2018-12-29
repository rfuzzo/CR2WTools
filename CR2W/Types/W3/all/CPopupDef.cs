using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPopupDef : CObject
{
#region RED Properties

[REDProp("timeParam")]
public Ptr<IPopupTimeParam> TimeParam { get; set;}

#endregion
}
}