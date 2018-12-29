using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMiscreantCryActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("miscreantName")]
public CName MiscreantName { get; set;}

#endregion
}
}