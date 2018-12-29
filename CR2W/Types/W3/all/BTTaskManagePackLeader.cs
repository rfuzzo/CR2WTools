using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManagePackLeader : IBehTreeTask
{
#region RED Properties

[REDProp("packName")]
public CName PackName { get; set;}

[REDProp("leadingRadius")]
public float LeadingRadius { get; set;}

[REDProp("forceMeAsLeader")]
public bool ForceMeAsLeader { get; set;}

[REDProp("m_checkDelay")]
public float M_checkDelay { get; set;}

#endregion
}
}