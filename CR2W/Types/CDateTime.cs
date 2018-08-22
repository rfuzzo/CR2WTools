using CR2W.Types.W3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    /*  - Format Info
     * 
     *  0000010110100001111000001010110001111110001000111011110000000000
     *  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
     *  |0 ||22  ||33  ||56  ||172     ||2018      ||7  ||15 ||0       |
     *  |  ||    ||    ||    ||        ||          ||   ||   ||________|____ 10 - Empty
     *  |  ||    ||    ||    ||        ||          ||   ||___|______________ 5  - Day - 1
     *  |  ||    ||    ||    ||        ||          ||___|___________________ 5  - Month - 1
     *  |  ||    ||    ||    ||        ||__________|________________________ 12 - Year
     *  |  ||    ||    ||    ||________|____________________________________ 10 - Millisecond
     *  |  ||    ||    ||____|______________________________________________ 6  - Second
     *  |  ||    ||____|____________________________________________________ 6  - Minute 
     *  |  ||____|__________________________________________________________ 6  - Hour
     *  |__|________________________________________________________________ 4  - Empty
     *  
     *  16/08/2018 22:33:56.172
     *  
     *  Month and day store their value in the ulong value with the day/month - 1.
     *  Because they are the only two values where their minimum value is 1 and not 0.
     *  When reading the values add 1 to the value, and when writing subtract 1 from the day/month to write.
     *  
     */
    [REDPrimitive]
    public struct CDateTime
    {
        /// <summary>
        /// The CDateTime value as a nullable .NET System.DateTime object.
        /// </summary>
        //This is nullable to tell if there should be no value and a valid datetime.
        private Nullable<DateTime> _value;

        /// <summary>
        /// Get the underlying .NET value from this CDatetime instance.
        /// </summary>
        /// <exception cref="InvalidOperationException">When the underlying value is null</exception>
        public DateTime Value => _value.Value;

        /// <summary>
        /// Initialise a new instance of the CDateTime object using a .NET System.DateTime object.
        /// </summary>
        /// <param name="value"></param>
        public CDateTime( DateTime value )
        {
            _value = value;
        }

        /// <summary>
        /// Initialise a new instance of the CDateTime object using a formatted redengine UInt64 value.
        /// If the value is formatted incorrectly, Min value will be used.
        /// </summary>
        /// <param name="value">A formatted UInt64 representing a datetime value.</param>
        public CDateTime( UInt64 value )
        {
            if(value == 0)
            {
                _value = null;
                return;
            }

            //Date
            value >>= 0xA;
            var day = Convert.ToInt32(value & 0x1F) + 1;
            value >>= 0x5;
            var month = Convert.ToInt32(value & 0x1F) + 1;
            value >>= 0x5;
            var year = Convert.ToInt32(value & 0xFFF);
            value >>= 0xC;

            //Time
            var millisecond = Convert.ToInt32(value & 0x3FF);
            value >>= 0xA;
            var second = Convert.ToInt32(value & 0x3F);
            value >>= 0x6;
            var minute = Convert.ToInt32(value & 0x3F);
            value >>= 0x6;
            var hour = Convert.ToInt32(value & 0X1FF);

            try
            {
                _value = new DateTime(year, month, day, hour, minute, second, millisecond);
            }
            catch(ArgumentOutOfRangeException)
            {
                _value = DateTime.MinValue;
            }
        }

        /// <summary>
        /// Get a CDateTime object set to the current time of the system.
        /// </summary>
        public static CDateTime Now => new CDateTime(DateTime.Now);

        /// <summary>
        /// Convert a CDateTime value into a redengine UInt64 compatible representation.
        /// </summary>
        /// <returns>
        /// A formatted UInt64 if the value is not null, and 0 if it is.
        /// </returns>
        public UInt64 ToUInt64()
        {
            var i = 0UL;
            if(_value == null)
            {
                return i;
            }
            var d = _value.Value;

            //Time
            i |= 0X1FF & Convert.ToUInt32(d.Hour);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(d.Minute);
            i <<= 0x6;
            i |= 0x3F & Convert.ToUInt32(d.Second);
            i <<= 0xA;
            i |= 0x3FF & Convert.ToUInt32(d.Millisecond);
            i <<= 0xC;

            //Date
            i |= 0xFFF & Convert.ToUInt32(d.Year);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(d.Month - 1);
            i <<= 0x5;
            i |= 0x1F & Convert.ToUInt32(d.Day - 1);
            i <<= 0xA;

            return i;
        }

        /// <summary>
        /// Returns a string representation of this instance.
        /// </summary>
        /// <returns>
        /// A formatted string if the value is not null and an empty string if it is.
        /// </returns>
        public override string ToString()
        {
            if(_value == null)
            {
                return "";
            }
            return _value.ToString();
        }


    }
}