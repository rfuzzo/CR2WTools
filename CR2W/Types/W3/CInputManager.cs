using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CInputManager : CObject
{
#region RED Properties

[REDProp("gestureSystem")]
public Ptr<CGestureSystem> GestureSystem { get; set;}

#endregion
}
}