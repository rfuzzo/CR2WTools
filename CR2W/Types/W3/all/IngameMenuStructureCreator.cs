using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IngameMenuStructureCreator : CObject
{
#region RED Properties

[REDProp("parentMenu")]
public Handle<CR4IngameMenu> ParentMenu { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_flashConstructor")]
public Handle<CScriptedFlashObject> M_flashConstructor { get; set;}

#endregion
}
}