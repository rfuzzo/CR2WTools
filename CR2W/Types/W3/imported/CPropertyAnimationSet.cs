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
public class CPropertyAnimationSet : CObject
{
#region RED Properties

[REDProp("animations", 2,0)]
public Array<SPropertyAnimation> Animations { get; set;}

#endregion
}
}