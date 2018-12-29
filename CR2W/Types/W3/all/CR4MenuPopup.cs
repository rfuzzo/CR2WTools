using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MenuPopup : CR4OverlayMenu
{
#region RED Properties

[REDProp("m_DataObject")]
public Handle<W3PopupData> M_DataObject { get; set;}

[REDProp("m_initialized")]
public bool M_initialized { get; set;}

[REDProp("m_HideTutorial")]
public bool M_HideTutorial { get; set;}

[REDProp("m_fxSetBarValueSFF")]
public Handle<CScriptedFlashFunction> M_fxSetBarValueSFF { get; set;}

[REDProp("rttItemLoaded")]
public bool RttItemLoaded { get; set;}

[REDProp("itemRotation")]
public EulerAngles ItemRotation { get; set;}

[REDProp("itemPosition")]
public Vector ItemPosition { get; set;}

[REDProp("itemScale")]
public Vector ItemScale { get; set;}

[REDProp("itemCat")]
public CName ItemCat { get; set;}

#endregion
}
}