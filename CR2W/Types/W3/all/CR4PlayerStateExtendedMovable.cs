using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateExtendedMovable : CPlayerStateMovable
{
#region RED Properties

[REDProp("parentMAC")]
public Handle<CMovingPhysicalAgentComponent> ParentMAC { get; set;}

[REDProp("currentStateName")]
public CName CurrentStateName { get; set;}

[REDProp("cameraChanneledSignEnabled")]
public bool CameraChanneledSignEnabled { get; set;}

[REDProp("m_shouldEnableAutoRotation")]
public bool M_shouldEnableAutoRotation { get; set;}

[REDProp("interiorCameraDesiredPositionMult")]
public float InteriorCameraDesiredPositionMult { get; set;}

#endregion
}
}