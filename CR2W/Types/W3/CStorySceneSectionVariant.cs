using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneSectionVariant 
{
#region RED Properties

[REDProp("id")]
public uint Id { get; set;}

[REDProp("localeId")]
public uint LocaleId { get; set;}

[REDProp("events")]
public Array<CGUID> Events { get; set;}

[REDProp("elementInfo")]
public Array<CStorySceneSectionVariantElementInfo> ElementInfo { get; set;}

#endregion
}
}