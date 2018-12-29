using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Aura : W3ApplicatorEffect
{
#region RED Properties

[REDProp("isOneTimeOnly")]
public bool IsOneTimeOnly { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("flags")]
public Int32 Flags { get; set;}

#endregion
}
}