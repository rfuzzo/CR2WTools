using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskOlgierdPhantomAttack : IBehTreeTask
{
#region RED Properties

[REDProp("phantomTemplate")]
public Handle<CEntityTemplate> PhantomTemplate { get; set;}

[REDProp("phantom")]
public Handle<W3CiriPhantom> Phantom { get; set;}

#endregion
}
}