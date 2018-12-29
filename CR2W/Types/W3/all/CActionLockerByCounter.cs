using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CActionLockerByCounter : CObject
{
#region RED Properties

[REDProp("lockingNum")]
public Int32 LockingNum { get; set;}

[REDProp("action")]
public EInputActionBlock Action { get; set;}

[REDProp("lockName")]
public CName LockName { get; set;}

#endregion
}
}