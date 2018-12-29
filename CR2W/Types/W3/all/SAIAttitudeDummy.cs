using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAIAttitudeDummy 
{
#region RED Properties

[REDProp("atttitude")]
public EAIAttitude Atttitude { get; set;}

#endregion
}
}