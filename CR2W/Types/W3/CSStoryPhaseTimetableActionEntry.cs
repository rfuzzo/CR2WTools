using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSStoryPhaseTimetableActionEntry 
{
#region RED Properties

[REDProp("layerName")]
public CSLayerName LayerName { get; set;}

[REDProp("actionCategories")]
public Array<CSStoryPhaseTimetableACategoriesEntry> ActionCategories { get; set;}

#endregion
}
}