using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBookMinigameSlot : CGameplayEntity
{
#region RED Properties

[REDProp("bookMinigameManagerTag")]
public CName BookMinigameManagerTag { get; set;}

[REDProp("correctBookId")]
public Int32 CorrectBookId { get; set;}

[REDProp("currentBook")]
public Handle<CBookMinigameBook> CurrentBook { get; set;}

[REDProp("bookMinigameManager")]
public Handle<CBooksMinigameManager> BookMinigameManager { get; set;}

#endregion
}
}