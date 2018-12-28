using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CJobTree : CResource
{
#region RED Properties

[REDProp("jobTreeRootNode")]
public Ptr<CJobTreeNode> JobTreeRootNode { get; set;}

[REDProp("movementMode")]
public EJobMovementMode MovementMode { get; set;}

[REDProp("customMovementSpeed")]
public float CustomMovementSpeed { get; set;}

[REDProp("settings")]
public SJobTreeSettings Settings { get; set;}

#endregion
}
}