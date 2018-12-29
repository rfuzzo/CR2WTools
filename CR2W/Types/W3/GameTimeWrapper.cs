using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class GameTimeWrapper 
{
#region RED Properties

[REDProp("gameTime")]
public GameTime GameTime { get; set;}

#endregion
}
}