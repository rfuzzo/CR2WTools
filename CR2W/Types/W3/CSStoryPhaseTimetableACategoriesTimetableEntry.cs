using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSStoryPhaseTimetableACategoriesTimetableEntry 
{
#region RED Properties

[REDProp("time")]
public GameTime Time { get; set;}

[REDProp("actions")]
public Array<CSStoryPhaseTimetableActionEntry> Actions { get; set;}

#endregion
}
}