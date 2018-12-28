using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEntityDismemberment : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("wounds")]
public Array<Ptr<CDismembermentWound>> Wounds { get; set;}

[REDProp("disabledWounds")]
public Array<SDismembermentWoundFilter> DisabledWounds { get; set;}

#endregion
}
}