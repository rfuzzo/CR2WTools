using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondBehVarCheckFloat : IBehTreeTask
{
#region RED Properties

[REDProp("behVarName")]
public CName BehVarName { get; set;}

[REDProp("behVarValue")]
public float BehVarValue { get; set;}

[REDProp("compareOperation")]
public ECompareOp CompareOperation { get; set;}

#endregion
}
}