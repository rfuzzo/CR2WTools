using System;
using System.Runtime.InteropServices;

namespace RED
{
    public struct IdTag : IEquatable<IdTag>
    {
        private bool m_dynamic;
        private CGUID m_id;

        public bool Dynamic
        {
            get => m_dynamic;
            set => m_dynamic = value;
        }
        public CGUID ID
        {
            get => m_id;
            set => m_id = value;
        }

        public IdTag(bool dynamic, CGUID id)
        {
            m_id = id;
            m_dynamic = dynamic;
        }

        public bool Equals(IdTag other)
        {
            if (this.m_dynamic != other.m_dynamic)
                return false;

            return this.m_id == other.m_id;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Dynamic ? "Dynamic" : "Static", ID.ToString());
        }
    }
}