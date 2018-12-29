using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CInputManager : CObject
{
#region RED Properties

[REDProp("gestureSystem")]
public Ptr<CGestureSystem> GestureSystem { get; set;}

#endregion
}
}