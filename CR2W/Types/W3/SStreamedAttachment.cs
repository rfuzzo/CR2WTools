
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SStreamedAttachment
	{
		[W3Type("parentName")]
		public CName ParentName { get; set; }

		[W3Type("parentClass")]
		public CName ParentClass { get; set; }

		[W3Type("childName")]
		public CName ChildName { get; set; }

		[W3Type("childClass")]
		public CName ChildClass { get; set; }

		[W3Type("data")]
        [W3ArrayFlags(2, 0)]
        public Array<Byte> Data { get; set; }

	}
}
