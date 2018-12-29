using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFormationPatternCompositeNode : IFormationPatternNode
{
#region RED Properties

[REDProp("childNodes")]
public Array<Handle<IFormationPatternNode>> ChildNodes { get; set;}

#endregion
}
}