using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerStateTraverseExploration : CPlayerStateBase
{
#region RED Properties

[REDProp("exploration")]
public SExplorationQueryToken Exploration { get; set;}

[REDProp("running")]
public bool Running { get; set;}

[REDProp("prevState")]
public CName PrevState { get; set;}

#endregion
}
}