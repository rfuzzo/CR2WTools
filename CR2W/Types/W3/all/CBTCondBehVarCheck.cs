using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondBehVarCheck : IBehTreeTask
{
#region RED Properties

[REDProp("behVarName")]
public CName BehVarName { get; set;}

[REDProp("behVarValue")]
public Int32 BehVarValue { get; set;}

[REDProp("compareOperation")]
public ECompareOp CompareOperation { get; set;}

#endregion
}
}