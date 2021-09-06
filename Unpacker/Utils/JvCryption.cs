

using Serilog;

namespace Unpacker.Utils
{
    public static class JvCryption
    {        
        public static byte[] privateKey = { 0x29, 0x6B, 0xD6, 0xEB, 0x2C, 0xA9, 0x03, 0x21};

        public static byte[] ItemKey = { 0x91, 0x3E, 0x2A, 0x85, 0xCB, 0x4C, 0x3D, 0x1B, 0xF2, 0x32, 0xD1, 0x72, 0xA8, 0xB0, 0xE3, 0x45, 0xD4, 0x12, 0xA2, 0x82, 0x67, 0x4B, 0x13, 0x66, 0xF6, 0x25, 0x87, 0x32, 0xA4, 0x1A, 0xB2, 0x7A, 0xB1, 0x62, 0xE3, 0x1B, 0x4A, 0x6C, 0x9A, 0x35, 0x72, 0x61, 0x74, 0x73, 0x79, 0x73, 0x61, 0x65 };

        public static byte[] JvDcrpytion(byte[] data, byte[] publicKey)
        {
            int len = data.Length;
            byte[] result = new byte[len];
            bool isCorrectLength = (len == 0 | len < 0);
            int rkey = 2157;
            int lkey = (157 * len) & 0xFF;
            if (!isCorrectLength)
            {
                for (int i = 0; i < len; i++)
                {
                    int pkey = ((privateKey[i % 8] ^ publicKey[i % 8]) ^ data[i]);
                    int rsk = pkey ^ ((rkey >> 8) & 0xFF);
                    int tfinal = rsk ^ lkey;
                    result[i] = (byte)tfinal;
                    rkey *= 2171;
                }
            }
            return result;
        }


        public static byte[] JvItemDecryption(byte[] data, byte[] publicKey)
        {

           
            int len = data.Length;
            byte[] result = new byte[len];
            bool isCorrectLength = (len == 0 | len < 0);
            int rkey = 2157;
            int lkey = (157 * len) & 0xFF;
            if (!isCorrectLength)
            {
                for (int i = 0; i < len; i++)
                {
                    int pkey = ((ItemKey[i % ItemKey.Length] ^ publicKey[i % 8]) ^ data[i]);
                    int rsk = pkey ^ ((rkey >> 8) & 0xFF);
                    int tfinal = rsk ^ lkey;
                    result[i] = (byte)tfinal;
                    rkey *= 2171;
                }
            }
            return result;
        }
        public static byte[] JvDecryptPacket(byte[] buff,byte[] publicKey)
        {
            int len = (buff[4] + (buff[5] << 8)), v10 = 2157, lena = (157 * len) & 0xFF;
            byte[] result = new byte[len];
            bool v8v9 = (len == 0 | len < 0);

            if (!v8v9)
            {
                for (int i = 0; i < len; i++)
                {
                    result[i] = (byte)((buff[12 + i] ^ lena) ^ (privateKey[i % 8] ^ publicKey[i % 8]) ^
                                        ((v10 >> 8) & 0xFF));
                    v10 *= 2171;
                }
            }
            result = LZF.Decompress(result, len);
            return result;
        }



    }
}
