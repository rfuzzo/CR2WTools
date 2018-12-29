using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SDismembermentWoundFilter 
{
#region RED Properties

[REDProp("wound")]
public CName Wound { get; set;}

[REDProp("appearance")]
public CName Appearance { get; set;}

#endregion
}
}