using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphStaticCondition_AnimTag : IBehaviorGraphStaticCondition
{
#region RED Properties

[REDProp("animTag")]
public CName AnimTag { get; set;}

#endregion
}
}