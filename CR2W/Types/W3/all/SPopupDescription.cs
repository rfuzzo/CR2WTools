using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SPopupDescription 
{
#region RED Properties

[REDProp("popupName")]
public CName PopupName { get; set;}

[REDProp("popupResource")]
public Soft<CPopupResource> PopupResource { get; set;}

#endregion
}
}