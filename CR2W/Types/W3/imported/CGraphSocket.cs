using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGraphSocket : ISerializable
{
#region RED Properties

[REDProp("block")]
public Ptr<CGraphBlock> Block { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("connections", 2,0)]
public Array<Ptr<CGraphConnection>> Connections { get; set;}

#endregion
public override ushort Flags { get; set; }
public override uint Template { get; set; }

public override event SerializeEventHandler Serialize;
public override event DeSerializeEventHandler DeSerialize;

public override void OnSerialize(IFile source, REDEventArgs e){}
public override void OnDeSerialize(IFile source, REDEventArgs e){}
}
}