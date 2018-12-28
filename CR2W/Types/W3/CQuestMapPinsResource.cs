using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestMapPinsResource : CResource
{
#region RED Properties

[REDProp("mappinsInfo")]
public Array<SQuestMapPinInfo> MappinsInfo { get; set;}

#endregion
}
}