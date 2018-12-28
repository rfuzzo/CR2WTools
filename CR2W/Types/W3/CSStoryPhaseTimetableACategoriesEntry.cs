using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSStoryPhaseTimetableACategoriesEntry 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("apTags")]
public TagList ApTags { get; set;}

#endregion
}
}