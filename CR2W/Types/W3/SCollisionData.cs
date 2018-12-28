using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCollisionData 
{
#region RED Properties

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("point")]
public Vector Point { get; set;}

[REDProp("normal")]
public Vector Normal { get; set;}

#endregion
}
}