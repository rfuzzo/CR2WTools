using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAnimalCharmed : CAIIdleTree
{
#region RED Properties

[REDProp("charmedGotoDistance")]
public float CharmedGotoDistance { get; set;}

#endregion
}
}