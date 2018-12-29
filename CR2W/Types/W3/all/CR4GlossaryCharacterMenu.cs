using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GlossaryCharacterMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("allCharacters")]
public Array<Handle<CJournalCharacter>> AllCharacters { get; set;}

#endregion
}
}