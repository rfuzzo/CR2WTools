using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFactsDBChoiceMemo : ISceneChoiceMemo
{
#region RED Properties

[REDProp("factID")]
public string FactID { get; set;}

[REDProp("value")]
public int Value { get; set;}

#endregion
}
}