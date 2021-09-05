

namespace Unpacker.Utils
{
    public static class JvCryption
    {
        public static byte[] privateKey = { 0x29, 0x6B, 0xD6, 0xEB, 0x2C, 0xA9, 0x03, 0x21 };
        public static byte[] JvDcrpytionWithCRC32(byte[] data, byte[] publicKey)
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
                    int v3 = rsk ^ lkey;
                    result[i] = (byte)v3;
                    rkey *= 2171;
                }
            }
            return result;
        }
    }
}
