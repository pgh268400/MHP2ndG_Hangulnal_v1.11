/*
  Decompiled with JetBrains decompiler
  Type: hpdPatchMHP2G.Form1
  Assembly: MonsterHunter2G KorPatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
  MVID: E2D0E602-1310-4EBF-B2D7-D651B15B3CDC
*/

using hpdPatchMHP2G.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hpdPatchMHP2G
{
    public class Form1 : Form
    {
        private HPDFont hpd_font = new HPDFont();
        private HPDData hpd_data = new HPDData();
        private string mhp2g_data_name = "MHP2G.DAT";
        private IContainer components;
        private OpenFileDialog open_file_dialog;
        private Label label4;
        private Panel panel_type;
        private Panel panel_yes_or_no;
        private PictureBox btn_exit;
        private Panel panel_btn;
        private PictureBox btn4;
        private PictureBox btn3;
        private PictureBox btn2;
        private PictureBox btn1;
        private PictureBox btn_type2;
        private PictureBox btn_type1;
        private PictureBox btn_start;
        private PictureBox btn_sear;
        private PictureBox btn_no;
        private PictureBox btn_yes;
        private Panel pnl_type_btn;
        private PictureBox picture_box1;
        private Timer timer1;
        private string iso_file_path;
        private Point mouse_offset;
        private int check_button;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            open_file_dialog = new OpenFileDialog();
            label4 = new Label();
            panel_type = new Panel();
            btn_start = new PictureBox();
            btn_sear = new PictureBox();
            btn_type2 = new PictureBox();
            btn_type1 = new PictureBox();
            panel_yes_or_no = new Panel();
            btn_yes = new PictureBox();
            btn_no = new PictureBox();
            btn_exit = new PictureBox();
            panel_btn = new Panel();
            btn4 = new PictureBox();
            btn3 = new PictureBox();
            btn2 = new PictureBox();
            btn1 = new PictureBox();
            pnl_type_btn = new Panel();
            picture_box1 = new PictureBox();
            timer1 = new Timer(components);
            panel_type.SuspendLayout();
            ((ISupportInitialize)(btn_start)).BeginInit();
            ((ISupportInitialize)(btn_sear)).BeginInit();
            ((ISupportInitialize)(btn_type2)).BeginInit();
            ((ISupportInitialize)(btn_type1)).BeginInit();
            panel_yes_or_no.SuspendLayout();
            ((ISupportInitialize)(btn_yes)).BeginInit();
            ((ISupportInitialize)(btn_no)).BeginInit();
            ((ISupportInitialize)(btn_exit)).BeginInit();
            panel_btn.SuspendLayout();
            ((ISupportInitialize)(btn4)).BeginInit();
            ((ISupportInitialize)(btn3)).BeginInit();
            ((ISupportInitialize)(btn2)).BeginInit();
            ((ISupportInitialize)(btn1)).BeginInit();
            pnl_type_btn.SuspendLayout();
            ((ISupportInitialize)(picture_box1)).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            open_file_dialog.FileName = "openFileDialog1";
            open_file_dialog.Filter = "ISO|*.iso";
            // 
            // label4
            // 
            label4.Font = new Font("굴림", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 292);
            label4.Name = "label4";
            label4.Size = new Size(346, 26);
            label4.TabIndex = 8;
            // 
            // panel_type
            // 
            panel_type.BackColor = Color.Transparent;
            panel_type.Controls.Add(btn_start);
            panel_type.Controls.Add(btn_sear);
            panel_type.Controls.Add(label4);
            panel_type.Location = new Point(15, 133);
            panel_type.Name = "panel_type";
            panel_type.Size = new Size(370, 346);
            panel_type.TabIndex = 9;
            panel_type.Visible = false;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(264, 321);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(97, 23);
            btn_start.TabIndex = 11;
            btn_start.TabStop = false;
            // 
            // btn_sear
            // 
            btn_sear.Location = new Point(10, 246);
            btn_sear.Name = "btn_sear";
            btn_sear.Size = new Size(157, 31);
            btn_sear.TabIndex = 10;
            btn_sear.TabStop = false;
            // 
            // btn_type2
            // 
            btn_type2.BackColor = Color.Transparent;
            btn_type2.Location = new Point(86, 0);
            btn_type2.Name = "btn_type2";
            btn_type2.Size = new Size(83, 21);
            btn_type2.TabIndex = 9;
            btn_type2.TabStop = false;
            btn_type2.Click += new EventHandler(btn_type2_Click);
            // 
            // btn_type1
            // 
            btn_type1.BackColor = Color.Transparent;
            btn_type1.Location = new Point(0, 0);
            btn_type1.Name = "btn_type1";
            btn_type1.Size = new Size(83, 21);
            btn_type1.TabIndex = 9;
            btn_type1.TabStop = false;
            btn_type1.Click += new EventHandler(btn_type1_Click);
            // 
            // panel_yes_or_no
            // 
            panel_yes_or_no.BackColor = Color.Transparent;
            panel_yes_or_no.Controls.Add(btn_yes);
            panel_yes_or_no.Controls.Add(btn_no);
            panel_yes_or_no.Location = new Point(37, 387);
            panel_yes_or_no.Name = "panel_yes_or_no";
            panel_yes_or_no.Size = new Size(326, 34);
            panel_yes_or_no.TabIndex = 10;
            panel_yes_or_no.Visible = false;
            // 
            // btn_Yes
            // 
            btn_yes.BackColor = Color.Transparent;
            btn_yes.Location = new Point(0, 0);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(148, 34);
            btn_yes.TabIndex = 0;
            btn_yes.TabStop = false;
            btn_yes.Click += new EventHandler(btn_Yes_Click);
            // 
            // btn_No
            // 
            btn_no.BackColor = Color.Transparent;
            btn_no.Location = new Point(178, 0);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(148, 34);
            btn_no.TabIndex = 0;
            btn_no.TabStop = false;
            btn_no.Click += new EventHandler(btn1_Click);
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.Cursor = Cursors.Cross;
            btn_exit.Location = new Point(327, 0);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(69, 14);
            btn_exit.TabIndex = 11;
            btn_exit.TabStop = false;
            btn_exit.Click += new EventHandler(pictureBox1_Click);
            // 
            // pnl_btn
            // 
            panel_btn.BackColor = Color.Transparent;
            panel_btn.Controls.Add(btn4);
            panel_btn.Controls.Add(btn3);
            panel_btn.Controls.Add(btn2);
            panel_btn.Controls.Add(btn1);
            panel_btn.Location = new Point(21, 91);
            panel_btn.Name = "panel_btn";
            panel_btn.Size = new Size(358, 35);
            panel_btn.TabIndex = 12;
            panel_btn.Visible = false;
            // 
            // btn4
            // 
            btn4.Location = new Point(267, 0);
            btn4.Name = "btn4";
            btn4.Size = new Size(91, 34);
            btn4.TabIndex = 0;
            btn4.TabStop = false;
            btn4.Click += new EventHandler(btn4_Click);
            // 
            // btn3
            // 
            btn3.Location = new Point(177, 0);
            btn3.Name = "btn3";
            btn3.Size = new Size(91, 34);
            btn3.TabIndex = 0;
            btn3.TabStop = false;
            btn3.Click += new EventHandler(btn3_Click);
            // 
            // btn2
            // 
            btn2.Location = new Point(89, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(91, 34);
            btn2.TabIndex = 0;
            btn2.TabStop = false;
            btn2.Click += new EventHandler(btn2_Click);
            // 
            // btn1
            // 
            btn1.Location = new Point(2, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(91, 34);
            btn1.TabIndex = 0;
            btn1.TabStop = false;
            btn1.Click += new EventHandler(btn1_Click);
            // 
            // pnl_type_btn
            // 
            pnl_type_btn.BackColor = Color.Transparent;
            pnl_type_btn.Controls.Add(btn_type1);
            pnl_type_btn.Controls.Add(btn_type2);
            pnl_type_btn.Location = new Point(29, 142);
            pnl_type_btn.Name = "pnl_type_btn";
            pnl_type_btn.Size = new Size(170, 21);
            pnl_type_btn.TabIndex = 13;
            // 
            // picture_box1
            // 
            picture_box1.BackColor = Color.Transparent;
            picture_box1.Cursor = Cursors.Cross;
            picture_box1.Location = new Point(0, 0);
            picture_box1.Name = "picture_box1";
            picture_box1.Size = new Size(400, 85);
            picture_box1.TabIndex = 14;
            picture_box1.TabStop = false;
            picture_box1.MouseDown += new MouseEventHandler(Form1_MouseDown);
            picture_box1.MouseMove += new MouseEventHandler(Form1_MouseMove);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(timer1_Tick);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.warn;
            ClientSize = new Size(400, 500);
            Controls.Add(btn_exit);
            Controls.Add(picture_box1);
            Controls.Add(pnl_type_btn);
            Controls.Add(panel_type);
            Controls.Add(panel_btn);
            Controls.Add(panel_yes_or_no);
            FormBorderStyle = FormBorderStyle.None;
            Icon = ((Icon)(resources.GetObject("$this.Icon")));
            MaximizeBox = false;
            Name = "Form1";
            Text = "MHP2G 한글날 v1.1";
            Load += new EventHandler(Form1_Load);
            panel_type.ResumeLayout(false);
            ((ISupportInitialize)(btn_start)).EndInit();
            ((ISupportInitialize)(btn_sear)).EndInit();
            ((ISupportInitialize)(btn_type2)).EndInit();
            ((ISupportInitialize)(btn_type1)).EndInit();
            panel_yes_or_no.ResumeLayout(false);
            ((ISupportInitialize)(btn_yes)).EndInit();
            ((ISupportInitialize)(btn_no)).EndInit();
            ((ISupportInitialize)(btn_exit)).EndInit();
            panel_btn.ResumeLayout(false);
            ((ISupportInitialize)(btn4)).EndInit();
            ((ISupportInitialize)(btn3)).EndInit();
            ((ISupportInitialize)(btn2)).EndInit();
            ((ISupportInitialize)(btn1)).EndInit();
            pnl_type_btn.ResumeLayout(false);
            ((ISupportInitialize)(picture_box1)).EndInit();
            ResumeLayout(false);

        }

        public Form1()
        {
            // 폼의 시작 위치를 화면 정중앙으로 설정
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private string get_name(string file_path)
        {
            int start_index = 0;
            while (file_path.IndexOf("\\", start_index) > 0)
                start_index = file_path.IndexOf("\\", start_index) + 1;
            return file_path.Substring(start_index);
        }

        private string get_game_id(FileStream fs)
        {
            long offset = 55296;
            BinaryReader binaryReader = new BinaryReader(fs);
            fs.Seek(offset, SeekOrigin.Begin);
            return Encoding.ASCII.GetString(binaryReader.ReadBytes(10));
        }

        private bool is_correct_iso(FileStream fs)
        {
            return fs.Length / 2048L == 437295L && !(get_game_id(fs) != "ULJM-05500");
        }

        private void pass_through_key(byte[] data)
        {
            byte num = 114;
            for (int index = 0; index < data.Length; ++index)
            {
                data[index] ^= num;
                num += 5;
            }
        }

        private bool is_correct_jpn0(byte[] buff)
        {
            return buff.Length == 1581700 && BitConverter.ToInt16(buff, 2) == 392 && (BitConverter.ToInt32(buff, 16) == 65504 && BitConverter.ToInt32(buff, 20) == 9778);
        }

        private bool is_correct_kr0()
        {
            FileStream fileStream;
            try
            {
                fileStream = new FileStream(Application.StartupPath + "\\kr0.pgf", FileMode.Open, FileAccess.Read);
            }
            catch
            {
                return false;
            }

            fileStream.Close();
            return true;
        }

        public byte[] make_font()
        {
            FileStream fileStream;
            try
            {
                fileStream = new FileStream(Application.StartupPath + "\\jpn0.pgf", FileMode.Open, FileAccess.Read);
            }
            catch
            {
                MessageBox.Show("폰트 읽기에 실패하였습니다");
                return null;
            }

            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] buff = binaryReader.ReadBytes((int)fileStream.Length);
            fileStream.Close();

            binaryReader.Close();

            /*
            if (!this.IsCorrectJpn0(buff))
                return (byte[])null;
            if (!this.IsCorrectKr0())
                return (byte[])null;
            */

            byte[] num_array = new byte[1914928];
            BitConverter.GetBytes(12128).CopyTo(buff, 20);
            byte[] data1 = (byte[])hpd_font.dat014D84.Clone();
            pass_through_key(data1);
            data1.CopyTo(buff, 85380);
            buff[119947] = 63;
            buff[119948] = 160;
            buff[119949] = 251;
            buff[120261] = 129;
            buff[120262] = 238;
            byte[] data2 = (byte[])hpd_font.dat01D61C.Clone();
            pass_through_key(data2);
            data2.CopyTo(buff, 120348);
            byte[] data3 = (byte[])hpd_font.dat01D7C4.Clone();
            pass_through_key(data3);
            data3.CopyTo(buff, 120772);
            byte[] data4 = (byte[])hpd_font.dat01DD58.Clone();
            pass_through_key(data4);
            data4.CopyTo(buff, 122200);
            byte[] data5 = (byte[])hpd_font.dat01DEC5.Clone();
            pass_through_key(data5);
            data5.CopyTo(buff, 122565);
            byte[] data6 = (byte[])hpd_font.dat01E04C.Clone();
            pass_through_key(data6);
            data6.CopyTo(buff, 122956);
            buff[122970] = 94;
            buff[122971] = 239;
            buff[123010] = 127;
            buff[123011] = 189;
            for (int index = 0; index < 145704; ++index)
                num_array[index] = buff[index];
            byte[] data7 = (byte[])hpd_font.dat023928.Clone();
            pass_through_key(data7);
            data7.CopyTo(num_array, 145704);
            for (int index = 0; index < 1403508; ++index)
                num_array[index + 151816] = buff[index + 146236];
            byte[] data8 = (byte[])hpd_font.dat17BB7C.Clone();
            pass_through_key(data8);
            for (int index = 0; index < data8.Length; ++index)
                num_array[index + 1555324] = data8[index];
            return num_array;
        }

        private void do_patch(string iso_path)
        {
            FileStream file_stream1;
            try
            {
                file_stream1 = new FileStream(Application.StartupPath + "\\" + "mhp2g.dat", FileMode.Open, FileAccess.Read);
            }
            catch
            {
                MessageBox.Show("패치에 필요한 파일을 찾지 못했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                BackgroundImage = Resources.main9;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
                return;
            }

            FileStream file_stream2;
            try
            {
                file_stream2 = new FileStream(iso_path, FileMode.Open, FileAccess.ReadWrite);
            }
            catch
            {
                MessageBox.Show("ISO 파일을 여는데 실패했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                file_stream1.Close();
                BackgroundImage = Resources.main9;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
                return;
            }

            /*
            if (!this.IsCorrectISO(fs))
            {
                int num = (int)MessageBox.Show("ISO 파일이 올바르지 않은 것 같습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                fileStream1.Close();
                fs.Close();
                this.BackgroundImage = (Image)Resources.main9;
                this.pnl_type.Visible = false;
                this.pnl_type_btn.Visible = false;
            }
            else
            {
            }
            */

            BinaryReader binary_reader = new BinaryReader(file_stream1);
            int total_entries = binary_reader.ReadInt32();
            if (binary_reader.ReadInt32() + 8 != file_stream1.Length)
            {
                MessageBox.Show("패치에 필요한 파일이 올바르지 않습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                file_stream1.Close();
                file_stream2.Close();
                BackgroundImage = Resources.main9;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
            }
            else
            {
                byte[] buffer = make_font();
                if (buffer == null)
                {
                    if (MessageBox.Show("새 폰트 파일을 만드는데 실패했습니다.\n계속하겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        file_stream1.Close();
                        file_stream2.Close();
                        return;
                    }
                }
                else
                {
                    FileStream file_stream3 = null;
                    try
                    {
                        file_stream3 = new FileStream(Application.StartupPath + "\\_jpn0.pgf", FileMode.Create, FileAccess.Write);
                    }
                    catch
                    {
                        file_stream1.Close();
                        file_stream2.Close();
                        MessageBox.Show("새 폰트 파일을 만드는데 실패했습니다.");
                    }
                    if (file_stream3 != null)
                    {
                        BinaryWriter binaryWriter = new BinaryWriter(file_stream3);
                        binaryWriter.Write(buffer);
                        binaryWriter.Close();
                        file_stream3.Close();
                    }
                }
                BinaryWriter binary_writer = new BinaryWriter(file_stream2);
                for (int index = 0; index < total_entries; index++)
                {
                    int num2 = binary_reader.ReadInt32() ^ 929682874;
                    int count = binary_reader.ReadInt32() ^ 929682874;
                    byte[] num_array = binary_reader.ReadBytes(count);
                    pass_through_key(num_array);
                    file_stream2.Seek(num2, SeekOrigin.Begin);
                    binary_writer.Write(num_array);
                }
                file_stream1.Close();
                file_stream2.Close();
                MessageBox.Show("패치가 완료되었습니다");
                BackgroundImage = Resources.main8;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
            }
        }


        private void do_patch_font(string iso_path)
        {

            FileStream file_stream1;

            try
            {
                file_stream1 = new FileStream(Application.StartupPath + "\\" + "mhp2g.dat", FileMode.Open, FileAccess.Read);
            }
            catch
            {
                MessageBox.Show("패치에 필요한 파일을 찾지 못 했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                BackgroundImage = Resources.main9;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
                return;
            }

            FileStream file_stream2;
            try
            {
                file_stream2 = new FileStream(iso_path, FileMode.Open, FileAccess.ReadWrite);
            }
            catch
            {
                MessageBox.Show("ISO 파일을 여는데 실패했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                file_stream1.Close();
                BackgroundImage = Resources.main9;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
                return;
            }


            /*
            if (!this.IsCorrectISO(fs))
            {
                MessageBox.Show("ISO 파일이 올바르지 않은 것 같습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                fileStream.Close();
                fs.Close();
                this.BackgroundImage = (Image)Resources.main9;
                this.pnl_type.Visible = false;
                this.pnl_type_btn.Visible = false;
            }
            else
            {
            }
            */

            BinaryReader binary_reader = new BinaryReader(file_stream1);
            int total_entries = binary_reader.ReadInt32();
            if (binary_reader.ReadInt32() + 8 != file_stream1.Length)
            {
                MessageBox.Show("패치에 필요한 파일이 올바르지 않습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                file_stream1.Close();
                file_stream2.Close();
                BackgroundImage = Resources.main9;
                panel_type.Visible = false;
                pnl_type_btn.Visible = false;
            }
            else
            {
                byte[] buffer = make_font();
                if (buffer == null)
                {
                    MessageBox.Show("새 폰트 파일을 만드는데 실패했습니다.", "경고", MessageBoxButtons.OK);
                    file_stream1.Close();
                    file_stream2.Close();
                }
                else
                {
                    BinaryWriter binaryWriter = new BinaryWriter(file_stream2);
                    for (int index = 0; index < total_entries; index++)
                    {
                        int num2 = binary_reader.ReadInt32() ^ 929682874;
                        int count = binary_reader.ReadInt32() ^ 929682874;
                        byte[] num_array = binary_reader.ReadBytes(count);
                        pass_through_key(num_array);
                        file_stream2.Seek(num2, SeekOrigin.Begin);
                        binaryWriter.Write(num_array);
                    }
                    file_stream2.Seek(51346L, SeekOrigin.Begin);
                    binaryWriter.Write(hpd_data.fat1);
                    file_stream2.Seek(53394L, SeekOrigin.Begin);
                    hpd_data.fat2.Initialize();
                    binaryWriter.Write(hpd_data.fat2);
                    file_stream2.Seek(1955840L, SeekOrigin.Begin);
                    binaryWriter.Write(hpd_data.oldfont);
                    file_stream2.Seek(1998848L, SeekOrigin.Begin);
                    binaryWriter.Write(buffer);
                    file_stream2.Seek(154140672L, SeekOrigin.Begin);
                    binaryWriter.Write(hpd_data.libfont);
                    file_stream1.Close();
                    file_stream2.Close();
                    MessageBox.Show("패치가 완료되었습니다");
                    BackgroundImage = Resources.main8;
                    panel_type.Visible = false;
                    pnl_type_btn.Visible = false;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            iso_file_path = null;
            open_file_dialog.FileName = "";
            if (open_file_dialog.ShowDialog() != DialogResult.OK)
                return;
            iso_file_path = open_file_dialog.FileName;
            label4.Text = get_name(iso_file_path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iso_file_path == null)
                return;
            do_patch(iso_file_path);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iso_file_path = null;
            open_file_dialog.FileName = "";
            if (open_file_dialog.ShowDialog() != DialogResult.OK)
                return;
            iso_file_path = open_file_dialog.FileName;
            label4.Text = get_name(iso_file_path);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            do_patch_font(iso_file_path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point mousePosition = MousePosition;
            mousePosition.Offset(mouse_offset.X, mouse_offset.Y);
            Location = mousePosition;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
              디버그 모드시 실행하면 프로그램 아이콘이 메세지 박스를 출력할 땐 표시되지 않지만,
              릴리즈 모드로 실행하면 프로그램 아이콘이 메세지 박스 출력시 정상적으로 나옴.
              이유는 잘 모르겠네 =ㅅ=
            */
            MessageBox.Show("Edited by File", "Welcome!");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.main1;
            panel_type.Visible = false;
            panel_yes_or_no.Visible = false;
            pnl_type_btn.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.main2;
            panel_type.Visible = false;
            panel_yes_or_no.Visible = false;
            pnl_type_btn.Visible = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.main3;
            panel_type.Visible = false;
            panel_yes_or_no.Visible = false;
            pnl_type_btn.Visible = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.main4;
            panel_type.Visible = false;
            panel_yes_or_no.Visible = true;
            pnl_type_btn.Visible = false;
        }

        private void check_btn()
        {
            switch (check_button)
            {
                case 1:
                    panel_type.Visible = true;
                    BackgroundImage = Resources.main6;
                    btn_sear.Click -= new EventHandler(button6_Click);
                    btn_sear.Click += new EventHandler(button1_Click);
                    btn_start.Click -= new EventHandler(button7_Click);
                    btn_start.Click += new EventHandler(button2_Click);
                    label4.Text = "";
                    check_button = 3;
                    break;
                case 2:
                    panel_type.Visible = true;
                    BackgroundImage = Resources.main7;
                    btn_sear.Click -= new EventHandler(button1_Click);
                    btn_sear.Click += new EventHandler(button6_Click);
                    btn_start.Click -= new EventHandler(button2_Click);
                    btn_start.Click += new EventHandler(button7_Click);
                    label4.Text = "";
                    check_button = 4;
                    break;
            }
        }

        private void btn_type1_Click(object sender, EventArgs e)
        {
            if (check_button == 3)
                return;
            check_button = 1;
            check_btn();
        }

        private void btn_type2_Click(object sender, EventArgs e)
        {
            if (check_button == 4)
                return;
            check_button = 2;
            check_btn();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.main5;
            btn_sear.Click -= new EventHandler(button6_Click);
            btn_start.Click -= new EventHandler(button7_Click);
            btn_sear.Click -= new EventHandler(button1_Click);
            btn_start.Click -= new EventHandler(button2_Click);
            check_button = 0;
            panel_yes_or_no.Visible = false;
            pnl_type_btn.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BackgroundImage = Resources.main1;
            panel_btn.Visible = true;
            timer1.Enabled = false;
        }
    }
}
