using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCachedConnections 
{
#region RED Properties

[REDProp("socketId")]
public CName SocketId { get; set;}

[REDProp("blocks")]
public Array<SBlockDesc> Blocks { get; set;}

#endregion
}
}