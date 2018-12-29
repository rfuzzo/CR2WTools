using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMenuBackgroundVideoAliasParam : IMenuBackgroundVideoParam
{
#region RED Properties

[REDProp("videoAlias")]
public CName VideoAlias { get; set;}

#endregion
}
}