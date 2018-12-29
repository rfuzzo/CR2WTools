using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Mutation7DebuffParams : W3BuffCustomParams
{
#region RED Properties

[REDProp("actorsCount")]
public Int32 ActorsCount { get; set;}

#endregion
}
}