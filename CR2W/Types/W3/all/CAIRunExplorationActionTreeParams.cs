using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIRunExplorationActionTreeParams : IAIActionParameters
{
#region RED Properties

[REDProp("explorationType")]
public EExplorationType ExplorationType { get; set;}

[REDProp("entityTag")]
public CName EntityTag { get; set;}

#endregion
}
}