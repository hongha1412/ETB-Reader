using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Unpacker.Utils;

namespace Unpacker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public byte[] publicKey;
        public void ConvertPublicKey(long key)
        {
            publicKey = BitConverter.GetBytes(key);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            System.Threading.Thread.Sleep(700);
            string path = @"FCTemp";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string path = @"mon_data.etb";
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(fs);

                    int Header1 = reader.ReadInt32();
                    long key = reader.ReadInt64();
                    int Header2 = reader.ReadInt32();
                    byte[] data = reader.ReadBytes((int)fs.Length - 4);


                    ConvertPublicKey(key);
                    byte[] unpack = JvCryption.JvDcrpytionWithCRC32(data, publicKey);
                    int len = unpack.Length;
                    byte[] decompress = lzf.Decompress(unpack, len);
                    FileStream writeStream;
                    try
                    {
                        writeStream = new FileStream("Temp_mon_data.etb", FileMode.Create);
                        BinaryWriter writeBinay = new BinaryWriter(writeStream);
                        writeBinay.Write(decompress);
                        writeBinay.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch
            {


                MessageBox.Show("This file is using by another process. \nPlease try again later.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void readTempFileMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"Temp_mon_data.etb";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs, Encoding.GetEncoding("UTF-16LE"));
                EtbFileHeader header = new EtbFileHeader
                {
                    RowCount = reader.ReadInt32(),
                    Unknow1 = reader.ReadInt32(),
                    Unknow2 = reader.ReadInt32(),
                    ColumnCount = reader.ReadInt32()
                };
                Console.WriteLine("Row Count: {0} Unknow : {1} Unknow : {2} Column Count : {3}", header.RowCount, header.Unknow1, header.Unknow2, header.ColumnCount);
                reader.ReadByte();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void readItemFile_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    string path = @"item.itm";
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(fs);

                    long header = reader.ReadInt64();
                    long key = reader.ReadInt64();
                    byte[] data = reader.ReadBytes((int)fs.Length - 16);
                    ConvertPublicKey(key);
                    Console.WriteLine("Key: {0}", key.ToString());
                    byte[] unpack = JvCryption.JvDcrpytionWithCRC32(data, publicKey);
                    // int len = unpack.Length;
                    //   byte[] decompress = Decrypt2(unpack, len);
                    FileStream writeStream;
                    try
                    {
                        writeStream = new FileStream("FCTemp", FileMode.Create);
                        BinaryWriter writeBinay = new BinaryWriter(writeStream);
                        for (int i = 0; i < unpack.Length; i++)
                        {
                            writeBinay.Write(unpack[i] - 20);
                        }
                        writeBinay.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    fs.Close();

                    MessageBox.Show("บันทึก FCTemp สำเร็จ", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            catch
            {

                MessageBox.Show("This file is using by another process. \nPlease try again later.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void checkUpdateMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No new update :)", "Info");
        }
    }

}
