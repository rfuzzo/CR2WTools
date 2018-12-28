using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class STargetSelectionData 
{
#region RED Properties

[REDProp("sourcePosition")]
public Vector SourcePosition { get; set;}

[REDProp("headingVector")]
public Vector HeadingVector { get; set;}

[REDProp("closeDistance")]
public float CloseDistance { get; set;}

[REDProp("softLockDistance")]
public float SoftLockDistance { get; set;}

#endregion
}
}