using System;

namespace Unpacker.Utils
{
    public static class lzf
    {
        public static byte[] Decompress(byte[] encryptPacket, int length)
        {
            int i = 0; // v5
            int j = 0; // v7
            int k = 0; // v13
            int l = 0; // v14
            int v4 = 0;
            byte[] v5 = new byte[0x20000];
            Array.Copy(encryptPacket, v5, encryptPacket.Length);
            byte[] v7 = new byte[0x20000];
            int v8 = 0;
            int v9 = 0;
            int v10 = 0;
            int v11 = 0;
            int v12 = 0;
            label:
            if (j >= 0x20000 || i >= length)
            {
                goto label2;
            }

            while (true)
            {
                v8 = v5[i++];
                if (v8 >= 0x20)
                    break;
                v9 = v8 + 1;
                do
                {
                    v7[j++] = v5[i++];
                    --v9;
                } while (v9 > 0);

                goto label;
            }

            v10 = v8;
            v11 = (v8 & 0x1F) << 8;
            v12 = v10 >> 5;
            if (v12 == 7)
                v12 = v5[i++] + 7;

            k = j - v11 - 1 - v5[i++];

            if (k >= v4)
            {
                v7[j] = v7[k];
                v7[j + 1] = v7[k + 1];
                j += 2;
                l = k + 2;
                do
                {
                    v7[j++] = v7[l++];
                    --v12;
                } while (v12 > 0);

                goto label;
            }

            label2:
            byte[] ret = new byte[j];
            Array.Copy(v7, ret, ret.Length);
            return ret;
        }
    }
}
