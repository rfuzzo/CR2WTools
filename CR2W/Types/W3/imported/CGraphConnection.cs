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
public class CGraphConnection : ISerializable
{
#region RED Properties

[REDProp("source")]
public Ptr<CGraphSocket> Source { get; set;}

[REDProp("destination")]
public Ptr<CGraphSocket> Destination { get; set;}

[REDProp("inactive")]
public bool Inactive { get; set;}

#endregion
public override ushort Flags { get; set; }
public override uint Template { get; set; }

public override event SerializeEventHandler Serialize;
public override event DeSerializeEventHandler DeSerialize;

public override void OnSerialize(IFile source, REDEventArgs e){}
public override void OnDeSerialize(IFile source, REDEventArgs e){}
}
}