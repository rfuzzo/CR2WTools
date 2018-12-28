using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SAlchemySubstanceData 
{
#region RED Properties

[REDProp("type")]
public CName Type { get; set;}

[REDProp("level")]
public int Level { get; set;}

[REDProp("isPermanent")]
public bool IsPermanent { get; set;}

#endregion
}
}