using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBookMinigameBook : CGameplayEntity
{
#region RED Properties

[REDProp("bookId")]
public Int32 BookId { get; set;}

#endregion
}
}