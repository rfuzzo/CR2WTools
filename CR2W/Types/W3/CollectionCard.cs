using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CollectionCard 
{
#region RED Properties

[REDProp("cardID")]
public int CardID { get; set;}

[REDProp("numCopies")]
public int NumCopies { get; set;}

#endregion
}
}