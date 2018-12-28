using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQCHasItem : CQCActorInventory
{
#region RED Properties

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("item")]
public CName Item { get; set;}

[REDProp("itemCategory")]
public CName ItemCategory { get; set;}

[REDProp("itemTag")]
public CName ItemTag { get; set;}

[REDProp("quantity")]
public uint Quantity { get; set;}

[REDProp("compareFunc")]
public ECompareFunc CompareFunc { get; set;}

#endregion
}
}