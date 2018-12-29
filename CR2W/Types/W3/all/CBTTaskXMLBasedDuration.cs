using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskXMLBasedDuration : CBTTaskBaseDuration
{
#region RED Properties

[REDProp("xmlStatName")]
public CName XmlStatName { get; set;}

#endregion
}
}