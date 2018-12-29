using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskIrisSpawn : BTTaskIrisTask
{
#region RED Properties

[REDProp("m_Painting")]
public Handle<CEntity> M_Painting { get; set;}

#endregion
}
}