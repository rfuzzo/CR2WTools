using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IBehTreeOnSpawnEffector : IBehTreeObjectDefinition
{
#region RED Properties

[REDProp("instanceClass")]
public CName InstanceClass { get; set;}

#endregion
}
}