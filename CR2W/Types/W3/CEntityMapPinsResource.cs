using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEntityMapPinsResource : CResource
{
#region RED Properties

[REDProp("mappinsInfo")]
public Array<SEntityMapPinInfo> MappinsInfo { get; set;}

#endregion
}
}