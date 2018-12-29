using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MinimapZoomScaleTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("zoomScale")]
public float ZoomScale { get; set;}

[REDProp("previousZoomScale")]
public float PreviousZoomScale { get; set;}

#endregion
}
}