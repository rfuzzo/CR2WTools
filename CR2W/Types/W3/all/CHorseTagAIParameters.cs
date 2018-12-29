using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHorseTagAIParameters : ICustomValAIParameters
{
#region RED Properties

[REDProp("preferedHorseTag")]
public CName PreferedHorseTag { get; set;}

#endregion
}
}