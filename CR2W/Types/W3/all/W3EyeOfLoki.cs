using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EyeOfLoki : W3QuestUsableItem
{
#region RED Properties

[REDProp("environment")]
public CName Environment { get; set;}

[REDProp("effect")]
public CName Effect { get; set;}

[REDProp("activeWhenFact")]
public CName ActiveWhenFact { get; set;}

[REDProp("soundOnStart")]
public CName SoundOnStart { get; set;}

[REDProp("soundOnStop")]
public CName SoundOnStop { get; set;}

[REDProp("envID")]
public Int32 EnvID { get; set;}

[REDProp("active")]
public bool Active { get; set;}

#endregion
}
}