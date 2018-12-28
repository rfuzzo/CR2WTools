using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SWorkWanderSmartAIEntryGeneratorParam 
{
#region RED Properties

[REDProp("apTag")]
public TagList ApTag { get; set;}

[REDProp("areaTags")]
public TagList AreaTags { get; set;}

[REDProp("apAreaTag")]
public CName ApAreaTag { get; set;}

#endregion
}
}