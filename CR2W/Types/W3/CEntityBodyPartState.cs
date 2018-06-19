
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntityBodyPartState
	{
		[W3Type("name")]
		public CName Name { get; set; }

		[W3Type("componentsInUse")]
        [W3ArrayFlags(2, 0)]
        public Array<CComponentReference> ComponentsInUse { get; set; }

	}
}
