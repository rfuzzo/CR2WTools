using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CUsableEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("bCanBeUsed")]
public bool BCanBeUsed { get; set;}

#endregion
}
}