using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_SetAppearanceOnEntity : W3SwitchEvent
{
#region RED Properties

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("appearanceName")]
public string AppearanceName { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

#endregion
}
}