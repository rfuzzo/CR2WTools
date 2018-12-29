using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MenuInitData : CObject
{
#region RED Properties

[REDProp("ignoreSaveSystem")]
public bool IgnoreSaveSystem { get; set;}

[REDProp("m_defaultState")]
public CName M_defaultState { get; set;}

#endregion
}
}