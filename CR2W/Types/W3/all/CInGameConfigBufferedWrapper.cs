using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CInGameConfigBufferedWrapper : CObject
{
#region RED Properties

[REDProp("inGameConfig")]
public Handle<CInGameConfigWrapper> InGameConfig { get; set;}

[REDProp("buffer")]
public Array<SInGameConfigBufferedEntry> Buffer { get; set;}

#endregion
}
}