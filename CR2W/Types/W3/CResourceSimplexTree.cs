using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CResourceSimplexTree : CResource
{
#region RED Properties

[REDProp("nodes")]
public Array<SSimplexTreeStruct> Nodes { get; set;}

#endregion
}
}