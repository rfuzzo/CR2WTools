
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntityBodyPart
	{
		[W3Type("name")]
		public CName Name { get; set; }

		[W3Type("states")]
        [W3ArrayFlags(2, 0)]
        public Array<CEntityBodyPartState> States { get; set; }

		[W3Type("wasIncluded")]
		public bool WasIncluded { get; set; }

	}
}
