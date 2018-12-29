using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIActionGossip : CAINpcActionSubtree
{
#region RED Properties

[REDProp("inInWorkBranch")]
public bool InInWorkBranch { get; set;}

#endregion
}
}