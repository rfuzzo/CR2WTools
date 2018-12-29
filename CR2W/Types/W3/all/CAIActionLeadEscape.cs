using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIActionLeadEscape : CAIMonsterActionSubtree
{
#region RED Properties

[REDProp("saveReactionTargetUnder")]
public CName SaveReactionTargetUnder { get; set;}

#endregion
}
}