using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFXSpawnerComponent : IFXSpawner
{
#region RED Properties

[REDProp("componentName")]
public CName ComponentName { get; set;}

[REDProp("copyRotation")]
public bool CopyRotation { get; set;}

[REDProp("attach")]
public bool Attach { get; set;}

[REDProp("relativeRotation")]
public EulerAngles RelativeRotation { get; set;}

[REDProp("relativePosition")]
public Vector RelativePosition { get; set;}

[REDProp("parentSlotName")]
public CName ParentSlotName { get; set;}

[REDProp("freePositionAxisX")]
public bool FreePositionAxisX { get; set;}

[REDProp("freePositionAxisY")]
public bool FreePositionAxisY { get; set;}

[REDProp("freePositionAxisZ")]
public bool FreePositionAxisZ { get; set;}

[REDProp("freeRotation")]
public bool FreeRotation { get; set;}

[REDProp("percentage")]
public float Percentage { get; set;}

#endregion
}
}