using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBgNpcJobTree 
{
#region RED Properties

[REDProp("jobTree")]
public Soft<CJobTree> JobTree { get; set;}

[REDProp("category")]
public CName Category { get; set;}

[REDProp("fireTime")]
public GameTime FireTime { get; set;}

#endregion
}
}