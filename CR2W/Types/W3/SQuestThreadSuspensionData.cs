using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SQuestThreadSuspensionData 
{
#region RED Properties

[REDProp("scopeBlockGUID")]
public CGUID ScopeBlockGUID { get; set;}

[REDProp("scopeData")]
public Array<byte> ScopeData { get; set;}

#endregion
}
}