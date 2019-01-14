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
public class CClipMapCookedData : ISerializable
{
#region RED Properties

#endregion
public override ushort Flags { get; set; }
public override uint Template { get; set; }

public override event SerializeEventHandler Serialize;
public override event DeSerializeEventHandler DeSerialize;

public override void OnSerialize(IFile source, REDEventArgs e){}
public override void OnDeSerialize(IFile source, REDEventArgs e){}
}
}