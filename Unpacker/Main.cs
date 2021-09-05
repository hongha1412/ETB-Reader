using AutoUpdaterDotNET;
using System;
using System.IO;
using System.Reflection;
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

            AutoUpdater.Start("https://cdn.pleum.in.th/ETBWorld/AutoUpdater.xml");
            AutoUpdater.Synchronous = true;
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            CurrentVersion.Text = "Current Version : " + Assembly.GetEntryAssembly().GetName().Version;
            System.Threading.Thread.Sleep(700);
            string path = @"FCTemp";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "GO Excel table|*.etb",
                Title = "Select a Excel Table File"
            };

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fullpath = openFileDialog1.FileName;
                string directoryPath = Path.GetDirectoryName(fullpath);
                string filename = System.IO.Path.GetFileName(fullpath);
                Console.WriteLine("full Path: {0}", fullpath);
                Console.WriteLine("Path: {0}", directoryPath);
                Console.WriteLine("Filename : {0}", filename);

                try
                {

                    try
                    {
                        string path = fullpath;
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        BinaryReader reader = new BinaryReader(fs);

                        int Header1 = reader.ReadInt32();
                        long key = reader.ReadInt64();
                        int Header2 = reader.ReadInt32();
                        byte[] data = reader.ReadBytes((int)fs.Length - 10);


                        ConvertPublicKey(key);
                        Console.WriteLine(key);

                        //Decryption
                        byte[] unpack = JvCryption.JvDcrpytionWithCRC32(data, publicKey);
                        int len = unpack.Length;

                        //Decompress file with LZF
                         byte[] decompress = LZF.Decompress(unpack, len);
                      
                        string tempfilename = directoryPath + @"\" + "_Temp_" + filename;
                        FileStream writeStream;
                        try
                        {
                            writeStream = new FileStream(tempfilename, FileMode.Create);
                            BinaryWriter writeBinay = new BinaryWriter(writeStream);
                            writeBinay.Write(decompress);
                            writeBinay.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        readData(tempfilename);
                        currentOpenFileLabel.Text = "ไฟล์ปัจจุบัน : " + filename;
                        currentOpenFileLabel.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("ไม่สามารถอ่านไฟล์ได้", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        EtbFileHeader header = new EtbFileHeader();
        public void readData(string filename)
        {
            try
            {
                string path = filename;
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs, Encoding.GetEncoding("UTF-16LE"));


                header.RowCount = reader.ReadInt32();
                header.Unknow1 = reader.ReadInt32();
                header.Unknow2 = reader.ReadInt32();
                header.ColumnCount = reader.ReadInt32();

                labelRowCount.Text = "Column Headers Count : " + header.ColumnCount.ToString() + " | " + " Data Row Count : " + header.RowCount.ToString();
                labelRowCount.Visible = true;
                Console.WriteLine("Row Count: {0} Unknow : {1} Unknow : {2} Column Count : {3}", header.RowCount, header.Unknow1, header.Unknow2, header.ColumnCount);


                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();


                int[] HeaderType = new int[header.ColumnCount];
                for (int i = 0; i < header.ColumnCount; i++)
                {

                    reader.ReadByte();//Start new Header

                    string str = "";
                    char ch;
                    while ((int)(ch = reader.ReadChar()) != 10) //stop when byte == 0xA
                        str = str + ch;
                    Console.WriteLine("COL: {0}", str);
                    HeaderType[i] = reader.ReadInt32(); //Type
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadInt32()); //FF FF 7F 7F
                    Console.WriteLine("RType: {0}", HeaderType[i]);

                    //READ Column name
                    string ColumnName = "";
                    char ch1;
                    while ((int)(ch1 = reader.ReadChar()) != 10) ColumnName = ColumnName + ch1;


                    dataGridView1.Columns.Add(str, "[ " + str + " ] " + ColumnName + " --> " + HeaderType[i]);
                }


                //ReadContent
                for (int j = 0; j < header.RowCount; j++)
                {
                    dataGridView1.Rows.Add();
                    for (int k = 0; k < header.ColumnCount; k++)
                    {
                        if (HeaderType[k] == 0)
                        {
                            dataGridView1[k, j].Value = reader.ReadInt32().ToString();
                        }
                        else if (HeaderType[k] == 2)
                        {
                          //  Console.log()
                            string stringname = "";
                            char stringch;
                            while ((int)(stringch = reader.ReadChar()) != 10)
                                stringname = stringname + stringch;
                            dataGridView1[k, j].Value = stringname.ToString();
                        }
                    }
                }
                fs.Close();
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "การอ่านไฟล์ล้มเหลว");
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
            }
        }

    

        private void exportToTextFileMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            // setup for export
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            // hiding row headers to avoid extra \t in exported text
            var rowHeaders = dataGridView1.RowHeadersVisible;
            dataGridView1.RowHeadersVisible = false;

            // ! creating text from grid values
            string content = dataGridView1.GetClipboardContent().GetText();

            // restoring grid state
            dataGridView1.ClearSelection();
            dataGridView1.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(dialog.FileName, content);
            MessageBox.Show(@" บันทีกข้อมูลเป็นไฟล์ .txt สำเร็จ");
        }

        private void openItemFileMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "GO Item table|*.itm",
                Title = "Select a Item Table File"
            };

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fullpath = openFileDialog1.FileName;
                string directoryPath = Path.GetDirectoryName(fullpath);
                string filename = System.IO.Path.GetFileName(fullpath);
                Console.WriteLine("full Path: {0}", fullpath);
                Console.WriteLine("Path: {0}", directoryPath);
                Console.WriteLine("Filename : {0}", filename);

                try
                {
                    string path = fullpath;
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(fs);
                    byte[] FileHeader = reader.ReadBytes(0x8);
                    long key = reader.ReadInt64();

                    ConvertPublicKey(key);
                    Console.WriteLine(key);
                    byte[] data = reader.ReadBytes((int)fs.Length - 16);
                    byte[] unpack = JvCryption.JvDcrpytionWithCRC32(data, publicKey);
                    
                    try
                    {
                        FileStream writeStream;
                        writeStream = new FileStream(@"FCTemp", FileMode.Create);
                        BinaryWriter writeBinay = new BinaryWriter(writeStream);
                        writeBinay.Write(unpack);
                        writeBinay.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                catch
                {
                    MessageBox.Show("การอ่านไฟล์ล้มเหลว", "");
                }
            }
        }
    }

}
