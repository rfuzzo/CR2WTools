using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PersistentRef 
{
#region RED Properties

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("rotation")]
public EulerAngles Rotation { get; set;}

#endregion
}
}