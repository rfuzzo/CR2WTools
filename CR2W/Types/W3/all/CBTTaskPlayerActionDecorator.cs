using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayerActionDecorator : IBehTreeTask
{
#region RED Properties

[REDProp("completeOnInput")]
public bool CompleteOnInput { get; set;}

[REDProp("prevContext")]
public CName PrevContext { get; set;}

#endregion
}
}