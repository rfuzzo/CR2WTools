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
public class CResourceSimplexTree : CResource
{
#region RED Properties

[REDProp("nodes", 2,0)]
public Array<SSimplexTreeStruct> Nodes { get; set;}

#endregion
}
}