using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SDLCLanguagePack 
{
#region RED Properties

[REDProp("textLanguages")]
public Array<string> TextLanguages { get; set;}

[REDProp("speechLanguages")]
public Array<string> SpeechLanguages { get; set;}

#endregion
}
}