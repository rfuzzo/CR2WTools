using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageFact : IBehTreeTask
{
#region RED Properties

[REDProp("fact")]
public string Fact { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("validFor")]
public Int32 ValidFor { get; set;}

[REDProp("add")]
public bool Add { get; set;}

[REDProp("doNotCompleteAfter")]
public bool DoNotCompleteAfter { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

#endregion
}
}