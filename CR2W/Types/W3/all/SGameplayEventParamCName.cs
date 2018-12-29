using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SGameplayEventParamCName 
{
#region RED Properties

[REDProp("value")]
public CName Value { get; set;}

#endregion
}
}