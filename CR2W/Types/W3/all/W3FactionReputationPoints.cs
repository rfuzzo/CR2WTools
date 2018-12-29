using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FactionReputationPoints : CObject
{
#region RED Properties

[REDProp("currentReputationPoints")]
public Int32 CurrentReputationPoints { get; set;}

[REDProp("negativeReputationPoints")]
public Int32 NegativeReputationPoints { get; set;}

#endregion
}
}