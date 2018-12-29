using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBooksMinigameManager : CGameplayEntity
{
#region RED Properties

[REDProp("minigameWonFact")]
public string MinigameWonFact { get; set;}

[REDProp("bookSlotTags")]
public Array<CName> BookSlotTags { get; set;}

[REDProp("bookTags")]
public Array<CName> BookTags { get; set;}

[REDProp("bookSlots")]
public Array<Handle<CBookMinigameSlot>> BookSlots { get; set;}

[REDProp("books")]
public Array<Handle<CBookMinigameBook>> Books { get; set;}

#endregion
}
}