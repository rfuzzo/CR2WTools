using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class SReverbDefinition 
	{
		#region RED Properties

		[REDProp("reverbName")]
		public StringAnsi ReverbName { get; set;}

		[REDProp("enabled")]
		public bool Enabled { get; set;}

		#endregion
	}
}