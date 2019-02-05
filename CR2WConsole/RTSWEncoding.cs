using RED;
using RED.IO;
using RED.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace CR2WConsole
{
    /*
     * File Format Info
     * ----------------
     * 
     *  4 Bytes FileId             - 0x52 0x54 0x53 0x57 (WSTR (le) Witcher Strings Resource)
     *  4 Bytes Version            - 0xA3 0x00 0x00 0x00 (163)
     *  2 Bytes Key 1              - First half of the key to lanaguge identifier.
     *  N Bytes String Count       - Number of string headers as a VLQInt32
     *  N Structs                  - Repeat for the size of the string count. 
     *      4 Bytes String Id      - The unique id used to id the string Xor-ed with the cipher key.
     *      4 Bytes DataOffset     - The offset into the character buffer the string starts.
     *      4 Bytes String Length  - The length of the string not including the terminating null character.
     *  N Bytes Hex Count          - Number of hex keys as a VLQInt32
     *      4 Bytes Key Key        - 32 bit hash of the string key (see hash algorithm)
     *      4 Bytes String Id      - The Id this hex value is linked to.
     *  N Bytes Character Count    - Size of the character buffer holding obfuscated null terminated strings.
     *  N UShort Characters        - An array of Ushort values holding all obfuscated strings in the files. 
     *  2 Bytes Key 2              - Second half of the key to lanaguge identifier.
     *  
     *  
     *  Obfuscation
     *  -------------
     *  
     *  Each null terminated string in the buffer is obfuscated using the following method:
     *  1) Take the cipher key and use the middle 16 bits of it as a character key.
     *  2) Multiply by character key by the length of the string (including the null terminator)
     *  3) XOR againt the character to either obfuscate or de-obfuscate.
     *  4) Rotate the character key 1 position to the left, and repeat from step 2 on the next character in the string.
     *  
     *  Those files with 0 as the cipher key are not obfucated and exist in plain text.
     *  
     *  
     *  Keys
     *  ----
     *  
     *  File Key    Cipher Key  Language Code
     *  0x00000000  0x00000000  ar
     *  0x00000000  0x00000000  br
     *  0x00000000  0x00000000  esMx
     *  0x00000000  0x00000000  kr
     *  0x00000000  0x00000000  tr
     *  0x62378349  0x73946816  pl
     *  0x51394397  0x79321793  en
     *  0x61387588  0x42791159  de
     *  0x18944593  0x12375973  it
     *  0x31762386  0x75921975  fr
     *  0x73542498  0x21793217  cz
     *  0x66511879  0x42387566  es
     *  0x21761863  0x16875467  zh
     *  0x14866348  0x42386347  ru
     *  0x89324237  0x67823218  hu
     *  0x48935483  0x59825646  jp
     *  
     *  
     *  Hashing Algorithm
     *  -----------------
     *  
     *  String keys are hashed to make a 32 bit value using the following algorithm.
     *  
     *  hash = 0
     *  foreach char c in string
     *      hash *= 31
     *      hash += c
     *  
     */

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct WSTRStringHeader
    {
        public uint idHash;
        public int offset;
        public int length;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct WSTRHexKey
    {
        public uint hexKey;
        public uint idHash;
    }

    public sealed class RTSWString
    {
        public UInt32 Id { get; set; }
        public UInt32 Key { get; set; }
        public String KeyExt { get; set; }
        public String Value { get; set; }
    }

    [ImmutableObject(true)]
    public sealed class Language
    {
        #region Private Fields
        private String m_code;
        private UInt32 m_key;
        private UInt32 m_magic;
        #endregion

        #region Instance
        public String Code => m_code;
        public UInt32 Key => m_key;
        public UInt32 Magic => m_magic;

        private Language(string code, uint key, uint magic)
        {
            m_code = code;
            m_key = key;
            m_magic = magic;
        }
        #endregion

        #region Static
        public static readonly Language AR = new Language("ar", 0x00000000, 0x00000000);
        public static readonly Language BR = new Language("br", 0x00000000, 0x00000000);
        public static readonly Language ESMX = new Language("esMX", 0x00000000, 0x00000000);
        public static readonly Language KR = new Language("kr", 0x00000000, 0x00000000);
        public static readonly Language TR = new Language("tr", 0x00000000, 0x00000000);
        public static readonly Language PL = new Language("pl", 0x62378349, 0x73946816);
        public static readonly Language EN = new Language("en", 0x51394397, 0x79321793);
        public static readonly Language DE = new Language("de", 0x61387588, 0x42791159);
        public static readonly Language IT = new Language("it", 0x18944593, 0x12375973);
        public static readonly Language FR = new Language("fr", 0x31762386, 0x75921975);
        public static readonly Language CZ = new Language("cz", 0x73542498, 0x21793217);
        public static readonly Language ES = new Language("es", 0x66511879, 0x42387566);
        public static readonly Language ZH = new Language("zh", 0x21761863, 0x16875467);
        public static readonly Language RU = new Language("ru", 0x14866348, 0x42386347);
        public static readonly Language HU = new Language("hu", 0x89324237, 0x67823218);
        public static readonly Language JP = new Language("jp", 0x48935483, 0x59825646);

        public static IEnumerable<Language> GetLanguages()
        {
            yield return AR;
            yield return BR;
            yield return ESMX;
            yield return KR;
            yield return TR;
            yield return PL;
            yield return EN;
            yield return DE;
            yield return IT;
            yield return FR;
            yield return CZ;
            yield return ES;
            yield return ZH;
            yield return RU;
            yield return HU;
            yield return JP;
        }

        public static Language GetLanguageByCode(string code)
        {
            return GetLanguages().FirstOrDefault(l => l.Code == code);
        }
        public static Language GetLanguageByKey(ushort key1, ushort key2)
        {
            return GetLanguageByKey((uint)(key2 << 16 | key1));
        }
        public static Language GetLanguageByKey(uint key)
        {
            return GetLanguages().FirstOrDefault(l => l.Key == key);
        }
        public static Language GetLanguageByMagic(uint magic)
        {
            return GetLanguages().FirstOrDefault(l => l.Magic == magic);
        }
        #endregion
    }

    public class StringsReader : REDBinaryReader
    {
        private const uint MAGIC   = 0x57535452; // WSTR (le) Witcher Strings Resource
        private const uint VERSION = 0xA3;       // 163

        private Language            language;
        private WSTRStringHeader[]  stringHeaders;
        private WSTRHexKey[]        hexKeys;
        private UInt16[]            charBuffer;

        public StringsReader(Stream stream)
            : base(stream, false)
        {
            ReadFileData();
        }

        public unsafe void ReadFileData()
        {
            var magic = ReadUInt32();
            if (magic != MAGIC)
            {
                throw new FileLoadException();
            }

            var version = ReadUInt32();
            if (version != VERSION)
            {
                throw new FileLoadException();
            }

            var key1            = ReadUInt16();
            var stringCount     = ReadVLQInt32().Size;
            var strings         = ReadStructs<WSTRStringHeader>(stringCount);
            var hexKeyCount     = ReadVLQInt32().Size;
            var hexKeys         = ReadStructs<WSTRHexKey>(hexKeyCount);
            var charCount       = ReadVLQInt32().Size;
            var charBuffer      = ReadUInt16s(charCount);
            var key2            = ReadUInt16();

            var lang = Language.GetLanguageByKey(key1, key2);

            strings = strings.OrderBy(s => s.offset).ToArray();


            var charKey = (ushort)(lang.Magic >> 8);

            var endStrings = new RTSWString[stringCount];
            fixed (ushort* cPtr = charBuffer)
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    DeObfuscateString((char*)(cPtr + strings[i].offset), strings[i].length, charKey);

                    endStrings[i] = new RTSWString()
                    {
                        Id = strings[i].idHash ^ lang.Magic,
                        Key = hexKeys.FirstOrDefault(h => h.idHash == strings[i].idHash).hexKey,
                        KeyExt = string.Empty,
                        Value = new string((char*)cPtr, strings[i].offset, strings[i].length),
                    };
                }
            }

            //foreach (var item in o)
            //{
            //    Console.WriteLine("{0,11}|{1:X8}|{2}|{3}", item.Id, item.Key, item.KeyExt, item.Value);
            //}
        }


        public override CName ReadCName()
        {
            throw new NotImplementedException();
        }

        public static unsafe void DeObfuscateString(char* cPtr, int length, ushort key)
        {
            for (int i = 0; i < length; i++)
            {
                var cKey = BitRotator.RotateLeft(key, i);
                *cPtr++ ^= (char)(cKey * (length + 1));
            }
        }

        public static unsafe void ObfuscateString(char* cPtr, string value, ushort key)
        {
            for (int i = 0; i < value.Length; i++)
            {
                var cKey = BitRotator.RotateLeft(key, i);
                *cPtr++ = (char)(value[i] ^ (cKey * (value.Length + 1)));
            }
        }

        public static uint HashStringKey(string key)
        {
            var bytes = Encoding.ASCII.GetBytes(key);
            var hash = 0u;
            unchecked
            {
                foreach (var b in bytes)
                {
                    hash *= 31;
                    hash += b;
                }
            }
            return hash;
        }
    }

}