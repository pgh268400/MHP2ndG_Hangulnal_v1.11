// Decompiled with JetBrains decompiler
// Type: hpdPatchMHP2G.Form1
// Assembly: MonsterHunter2G KorPatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E2D0E602-1310-4EBF-B2D7-D651B15B3CDC
// Assembly location: E:\Game\PSP\MHP2ndG_Hangulnal_v1.11\MHP2G_Hangulnal.exe

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
    private HPDFont hpdFont = new HPDFont();
    private HPDData hpdData = new HPDData();
    private string mhp2gdatname = "MHP2G.DAT";
    private IContainer components;
    private OpenFileDialog openFileDialog1;
    private Label label4;
    private Panel pnl_type;
    private Panel pnl_YesorNo;
    private PictureBox btn_exit;
    private Panel pnl_btn;
    private PictureBox btn4;
    private PictureBox btn3;
    private PictureBox btn2;
    private PictureBox btn1;
    private PictureBox btn_type2;
    private PictureBox btn_type1;
    private PictureBox btn_start;
    private PictureBox btn_sear;
    private PictureBox btn_No;
    private PictureBox btn_Yes;
    private Panel pnl_type_btn;
    private PictureBox pictureBox1;
    private Timer timer1;
    private string isofilepath;
    private Point mouse_offset;
    private int Check_btn;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.openFileDialog1 = new OpenFileDialog();
      this.label4 = new Label();
      this.pnl_type = new Panel();
      this.btn_start = new PictureBox();
      this.btn_sear = new PictureBox();
      this.btn_type2 = new PictureBox();
      this.btn_type1 = new PictureBox();
      this.pnl_YesorNo = new Panel();
      this.btn_Yes = new PictureBox();
      this.btn_No = new PictureBox();
      this.btn_exit = new PictureBox();
      this.pnl_btn = new Panel();
      this.btn4 = new PictureBox();
      this.btn3 = new PictureBox();
      this.btn2 = new PictureBox();
      this.btn1 = new PictureBox();
      this.pnl_type_btn = new Panel();
      this.pictureBox1 = new PictureBox();
      this.timer1 = new Timer(this.components);
      this.pnl_type.SuspendLayout();
      ((ISupportInitialize) this.btn_start).BeginInit();
      ((ISupportInitialize) this.btn_sear).BeginInit();
      ((ISupportInitialize) this.btn_type2).BeginInit();
      ((ISupportInitialize) this.btn_type1).BeginInit();
      this.pnl_YesorNo.SuspendLayout();
      ((ISupportInitialize) this.btn_Yes).BeginInit();
      ((ISupportInitialize) this.btn_No).BeginInit();
      ((ISupportInitialize) this.btn_exit).BeginInit();
      this.pnl_btn.SuspendLayout();
      ((ISupportInitialize) this.btn4).BeginInit();
      ((ISupportInitialize) this.btn3).BeginInit();
      ((ISupportInitialize) this.btn2).BeginInit();
      ((ISupportInitialize) this.btn1).BeginInit();
      this.pnl_type_btn.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "ISO|*.iso";
      this.label4.Font = new Font("굴림", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 129);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(13, 292);
      this.label4.Name = "label4";
      this.label4.Size = new Size(346, 26);
      this.label4.TabIndex = 8;
      this.pnl_type.BackColor = Color.Transparent;
      this.pnl_type.Controls.Add((Control) this.btn_start);
      this.pnl_type.Controls.Add((Control) this.btn_sear);
      this.pnl_type.Controls.Add((Control) this.label4);
      this.pnl_type.Location = new Point(15, 133);
      this.pnl_type.Name = "pnl_type";
      this.pnl_type.Size = new Size(370, 346);
      this.pnl_type.TabIndex = 9;
      this.pnl_type.Visible = false;
      this.btn_start.Location = new Point(264, 321);
      this.btn_start.Name = "btn_start";
      this.btn_start.Size = new Size(97, 23);
      this.btn_start.TabIndex = 11;
      this.btn_start.TabStop = false;
      this.btn_sear.Location = new Point(10, 246);
      this.btn_sear.Name = "btn_sear";
      this.btn_sear.Size = new Size(157, 31);
      this.btn_sear.TabIndex = 10;
      this.btn_sear.TabStop = false;
      this.btn_type2.BackColor = Color.Transparent;
      this.btn_type2.Location = new Point(86, 0);
      this.btn_type2.Name = "btn_type2";
      this.btn_type2.Size = new Size(83, 21);
      this.btn_type2.TabIndex = 9;
      this.btn_type2.TabStop = false;
      this.btn_type2.Click += new EventHandler(this.btn_type2_Click);
      this.btn_type1.BackColor = Color.Transparent;
      this.btn_type1.Location = new Point(0, 0);
      this.btn_type1.Name = "btn_type1";
      this.btn_type1.Size = new Size(83, 21);
      this.btn_type1.TabIndex = 9;
      this.btn_type1.TabStop = false;
      this.btn_type1.Click += new EventHandler(this.btn_type1_Click);
      this.pnl_YesorNo.BackColor = Color.Transparent;
      this.pnl_YesorNo.Controls.Add((Control) this.btn_Yes);
      this.pnl_YesorNo.Controls.Add((Control) this.btn_No);
      this.pnl_YesorNo.Location = new Point(37, 387);
      this.pnl_YesorNo.Name = "pnl_YesorNo";
      this.pnl_YesorNo.Size = new Size(326, 34);
      this.pnl_YesorNo.TabIndex = 10;
      this.pnl_YesorNo.Visible = false;
      this.btn_Yes.BackColor = Color.Transparent;
      this.btn_Yes.Location = new Point(0, 0);
      this.btn_Yes.Name = "btn_Yes";
      this.btn_Yes.Size = new Size(148, 34);
      this.btn_Yes.TabIndex = 0;
      this.btn_Yes.TabStop = false;
      this.btn_Yes.Click += new EventHandler(this.btn_Yes_Click);
      this.btn_No.BackColor = Color.Transparent;
      this.btn_No.Location = new Point(178, 0);
      this.btn_No.Name = "btn_No";
      this.btn_No.Size = new Size(148, 34);
      this.btn_No.TabIndex = 0;
      this.btn_No.TabStop = false;
      this.btn_No.Click += new EventHandler(this.btn1_Click);
      this.btn_exit.BackColor = Color.Transparent;
      this.btn_exit.Cursor = Cursors.Cross;
      this.btn_exit.Location = new Point(327, 0);
      this.btn_exit.Name = "btn_exit";
      this.btn_exit.Size = new Size(69, 14);
      this.btn_exit.TabIndex = 11;
      this.btn_exit.TabStop = false;
      this.btn_exit.Click += new EventHandler(this.pictureBox1_Click);
      this.pnl_btn.BackColor = Color.Transparent;
      this.pnl_btn.Controls.Add((Control) this.btn4);
      this.pnl_btn.Controls.Add((Control) this.btn3);
      this.pnl_btn.Controls.Add((Control) this.btn2);
      this.pnl_btn.Controls.Add((Control) this.btn1);
      this.pnl_btn.Location = new Point(21, 91);
      this.pnl_btn.Name = "pnl_btn";
      this.pnl_btn.Size = new Size(358, 35);
      this.pnl_btn.TabIndex = 12;
      this.pnl_btn.Visible = false;
      this.btn4.Location = new Point(267, 0);
      this.btn4.Name = "btn4";
      this.btn4.Size = new Size(91, 34);
      this.btn4.TabIndex = 0;
      this.btn4.TabStop = false;
      this.btn4.Click += new EventHandler(this.btn4_Click);
      this.btn3.Location = new Point(177, 0);
      this.btn3.Name = "btn3";
      this.btn3.Size = new Size(91, 34);
      this.btn3.TabIndex = 0;
      this.btn3.TabStop = false;
      this.btn3.Click += new EventHandler(this.btn3_Click);
      this.btn2.Location = new Point(89, 0);
      this.btn2.Name = "btn2";
      this.btn2.Size = new Size(91, 34);
      this.btn2.TabIndex = 0;
      this.btn2.TabStop = false;
      this.btn2.Click += new EventHandler(this.btn2_Click);
      this.btn1.Location = new Point(2, 0);
      this.btn1.Name = "btn1";
      this.btn1.Size = new Size(91, 34);
      this.btn1.TabIndex = 0;
      this.btn1.TabStop = false;
      this.btn1.Click += new EventHandler(this.btn1_Click);
      this.pnl_type_btn.BackColor = Color.Transparent;
      this.pnl_type_btn.Controls.Add((Control) this.btn_type1);
      this.pnl_type_btn.Controls.Add((Control) this.btn_type2);
      this.pnl_type_btn.Location = new Point(29, 142);
      this.pnl_type_btn.Name = "pnl_type_btn";
      this.pnl_type_btn.Size = new Size(170, 21);
      this.pnl_type_btn.TabIndex = 13;
      this.pictureBox1.BackColor = Color.Transparent;
      this.pictureBox1.Cursor = Cursors.Cross;
      this.pictureBox1.Location = new Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(400, 85);
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
      this.pictureBox1.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
      this.timer1.Enabled = true;
      this.timer1.Interval = 10000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(7f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) Resources.warn;
      this.ClientSize = new Size(400, 500);
      this.Controls.Add((Control) this.btn_exit);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.pnl_type_btn);
      this.Controls.Add((Control) this.pnl_type);
      this.Controls.Add((Control) this.pnl_btn);
      this.Controls.Add((Control) this.pnl_YesorNo);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.Text = "MHP2G 한글날 v1.1";
      this.Load += new EventHandler(this.Form1_Load);
      this.pnl_type.ResumeLayout(false);
      ((ISupportInitialize) this.btn_start).EndInit();
      ((ISupportInitialize) this.btn_sear).EndInit();
      ((ISupportInitialize) this.btn_type2).EndInit();
      ((ISupportInitialize) this.btn_type1).EndInit();
      this.pnl_YesorNo.ResumeLayout(false);
      ((ISupportInitialize) this.btn_Yes).EndInit();
      ((ISupportInitialize) this.btn_No).EndInit();
      ((ISupportInitialize) this.btn_exit).EndInit();
      this.pnl_btn.ResumeLayout(false);
      ((ISupportInitialize) this.btn4).EndInit();
      ((ISupportInitialize) this.btn3).EndInit();
      ((ISupportInitialize) this.btn2).EndInit();
      ((ISupportInitialize) this.btn1).EndInit();
      this.pnl_type_btn.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }

    public Form1()
    {
      this.InitializeComponent();
    }

    private string getName(string filepath)
    {
      int startIndex = 0;
      while (filepath.IndexOf("\\", startIndex) > 0)
        startIndex = filepath.IndexOf("\\", startIndex) + 1;
      return filepath.Substring(startIndex);
    }

    private string GetGameID(FileStream fs)
    {
      long offset = 55296;
      BinaryReader binaryReader = new BinaryReader((Stream) fs);
      fs.Seek(offset, SeekOrigin.Begin);
      return Encoding.ASCII.GetString(binaryReader.ReadBytes(10));
    }

    private bool IsCorrectISO(FileStream fs)
    {
      return fs.Length / 2048L == 437295L && !(this.GetGameID(fs) != "ULJM-05500");
    }

    private void PassThroughKey(byte[] data)
    {
      byte num = 114;
      for (int index = 0; index < data.Length; ++index)
      {
        data[index] ^= num;
        num += (byte) 5;
      }
    }

    private bool IsCorrectJpn0(byte[] buff)
    {
      return buff.Length == 1581700 && BitConverter.ToInt16(buff, 2) == (short) 392 && (BitConverter.ToInt32(buff, 16) == 65504 && BitConverter.ToInt32(buff, 20) == 9778);
    }

    private bool IsCorrectKr0()
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
      if (fileStream.Length != 394192L)
      {
        fileStream.Close();
        return false;
      }
      fileStream.Close();
      return true;
    }

    public byte[] MakeFont()
    {
      FileStream fileStream;
      try
      {
        fileStream = new FileStream(Application.StartupPath + "\\jpn0.pgf", FileMode.Open, FileAccess.Read);
      }
      catch
      {
        return (byte[]) null;
      }
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      byte[] buff = binaryReader.ReadBytes((int) fileStream.Length);
      fileStream.Close();
      binaryReader.Close();
      if (!this.IsCorrectJpn0(buff))
        return (byte[]) null;
      if (!this.IsCorrectKr0())
        return (byte[]) null;
      byte[] numArray = new byte[1914928];
      BitConverter.GetBytes(12128).CopyTo((Array) buff, 20);
      byte[] data1 = (byte[]) this.hpdFont.dat014D84.Clone();
      this.PassThroughKey(data1);
      data1.CopyTo((Array) buff, 85380);
      buff[119947] = (byte) 63;
      buff[119948] = (byte) 160;
      buff[119949] = (byte) 251;
      buff[120261] = (byte) 129;
      buff[120262] = (byte) 238;
      byte[] data2 = (byte[]) this.hpdFont.dat01D61C.Clone();
      this.PassThroughKey(data2);
      data2.CopyTo((Array) buff, 120348);
      byte[] data3 = (byte[]) this.hpdFont.dat01D7C4.Clone();
      this.PassThroughKey(data3);
      data3.CopyTo((Array) buff, 120772);
      byte[] data4 = (byte[]) this.hpdFont.dat01DD58.Clone();
      this.PassThroughKey(data4);
      data4.CopyTo((Array) buff, 122200);
      byte[] data5 = (byte[]) this.hpdFont.dat01DEC5.Clone();
      this.PassThroughKey(data5);
      data5.CopyTo((Array) buff, 122565);
      byte[] data6 = (byte[]) this.hpdFont.dat01E04C.Clone();
      this.PassThroughKey(data6);
      data6.CopyTo((Array) buff, 122956);
      buff[122970] = (byte) 94;
      buff[122971] = (byte) 239;
      buff[123010] = (byte) 127;
      buff[123011] = (byte) 189;
      for (int index = 0; index < 145704; ++index)
        numArray[index] = buff[index];
      byte[] data7 = (byte[]) this.hpdFont.dat023928.Clone();
      this.PassThroughKey(data7);
      data7.CopyTo((Array) numArray, 145704);
      for (int index = 0; index < 1403508; ++index)
        numArray[index + 151816] = buff[index + 146236];
      byte[] data8 = (byte[]) this.hpdFont.dat17BB7C.Clone();
      this.PassThroughKey(data8);
      for (int index = 0; index < data8.Length; ++index)
        numArray[index + 1555324] = data8[index];
      return numArray;
    }

    private void DoPatch(string isopath)
    {
      FileStream fileStream1;
      try
      {
        fileStream1 = new FileStream(Application.StartupPath + "\\" + this.mhp2gdatname, FileMode.Open, FileAccess.Read);
      }
      catch
      {
        int num = (int) MessageBox.Show("패치에 필요한 파일을 찾지 못 했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.BackgroundImage = (Image) Resources.main9;
        this.pnl_type.Visible = false;
        this.pnl_type_btn.Visible = false;
        return;
      }
      FileStream fs;
      try
      {
        fs = new FileStream(isopath, FileMode.Open, FileAccess.ReadWrite);
      }
      catch
      {
        int num = (int) MessageBox.Show("ISO 파일을 여는데 실패했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        fileStream1.Close();
        this.BackgroundImage = (Image) Resources.main9;
        this.pnl_type.Visible = false;
        this.pnl_type_btn.Visible = false;
        return;
      }
      if (!this.IsCorrectISO(fs))
      {
        int num = (int) MessageBox.Show("ISO 파일이 올바르지 않은 것 같습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        fileStream1.Close();
        fs.Close();
        this.BackgroundImage = (Image) Resources.main9;
        this.pnl_type.Visible = false;
        this.pnl_type_btn.Visible = false;
      }
      else
      {
        BinaryReader binaryReader = new BinaryReader((Stream) fileStream1);
        int num1 = binaryReader.ReadInt32();
        if ((long) (binaryReader.ReadInt32() + 8) != fileStream1.Length)
        {
          int num2 = (int) MessageBox.Show("패치에 필요한 파일이 올바르지 않습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          fileStream1.Close();
          fs.Close();
          this.BackgroundImage = (Image) Resources.main9;
          this.pnl_type.Visible = false;
          this.pnl_type_btn.Visible = false;
        }
        else
        {
          byte[] buffer = this.MakeFont();
          if (buffer == null)
          {
            if (MessageBox.Show("새 폰트 파일을 만드는데 실패했습니다.\n계속하겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No)
            {
              fileStream1.Close();
              fs.Close();
              return;
            }
          }
          else
          {
            FileStream fileStream2 = (FileStream) null;
            try
            {
              fileStream2 = new FileStream(Application.StartupPath + "\\_jpn0.pgf", FileMode.Create, FileAccess.Write);
            }
            catch
            {
              fileStream1.Close();
              fs.Close();
              int num2 = (int) MessageBox.Show("새 폰트 파일을 만드는데 실패했습니다.");
            }
            if (fileStream2 != null)
            {
              BinaryWriter binaryWriter = new BinaryWriter((Stream) fileStream2);
              binaryWriter.Write(buffer);
              binaryWriter.Close();
              fileStream2.Close();
            }
          }
          BinaryWriter binaryWriter1 = new BinaryWriter((Stream) fs);
          for (int index = 0; index < num1; ++index)
          {
            int num2 = binaryReader.ReadInt32() ^ 929682874;
            int count = binaryReader.ReadInt32() ^ 929682874;
            byte[] numArray = binaryReader.ReadBytes(count);
            this.PassThroughKey(numArray);
            fs.Seek((long) num2, SeekOrigin.Begin);
            binaryWriter1.Write(numArray);
          }
          fileStream1.Close();
          fs.Close();
          int num3 = (int) MessageBox.Show("패치가 완료되었습니다");
          this.BackgroundImage = (Image) Resources.main8;
          this.pnl_type.Visible = false;
          this.pnl_type_btn.Visible = false;
        }
      }
    }

    private void DoPatchFont(string isopath)
    {
      FileStream fileStream;
      try
      {
        fileStream = new FileStream(Application.StartupPath + "\\" + this.mhp2gdatname, FileMode.Open, FileAccess.Read);
      }
      catch
      {
        int num = (int) MessageBox.Show("패치에 필요한 파일을 찾지 못 했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.BackgroundImage = (Image) Resources.main9;
        this.pnl_type.Visible = false;
        this.pnl_type_btn.Visible = false;
        return;
      }
      FileStream fs;
      try
      {
        fs = new FileStream(isopath, FileMode.Open, FileAccess.ReadWrite);
      }
      catch
      {
        int num = (int) MessageBox.Show("ISO 파일을 여는데 실패했습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        fileStream.Close();
        this.BackgroundImage = (Image) Resources.main9;
        this.pnl_type.Visible = false;
        this.pnl_type_btn.Visible = false;
        return;
      }
      if (!this.IsCorrectISO(fs))
      {
        int num = (int) MessageBox.Show("ISO 파일이 올바르지 않은 것 같습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        fileStream.Close();
        fs.Close();
        this.BackgroundImage = (Image) Resources.main9;
        this.pnl_type.Visible = false;
        this.pnl_type_btn.Visible = false;
      }
      else
      {
        BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
        int num1 = binaryReader.ReadInt32();
        if ((long) (binaryReader.ReadInt32() + 8) != fileStream.Length)
        {
          int num2 = (int) MessageBox.Show("패치에 필요한 파일이 올바르지 않습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          fileStream.Close();
          fs.Close();
          this.BackgroundImage = (Image) Resources.main9;
          this.pnl_type.Visible = false;
          this.pnl_type_btn.Visible = false;
        }
        else
        {
          byte[] buffer = this.MakeFont();
          if (buffer == null)
          {
            int num2 = (int) MessageBox.Show("새 폰트 파일을 만드는데 실패했습니다.", "경고", MessageBoxButtons.OK);
            fileStream.Close();
            fs.Close();
          }
          else
          {
            BinaryWriter binaryWriter = new BinaryWriter((Stream) fs);
            for (int index = 0; index < num1; ++index)
            {
              int num2 = binaryReader.ReadInt32() ^ 929682874;
              int count = binaryReader.ReadInt32() ^ 929682874;
              byte[] numArray = binaryReader.ReadBytes(count);
              this.PassThroughKey(numArray);
              fs.Seek((long) num2, SeekOrigin.Begin);
              binaryWriter.Write(numArray);
            }
            fs.Seek(51346L, SeekOrigin.Begin);
            binaryWriter.Write(this.hpdData.fat1);
            fs.Seek(53394L, SeekOrigin.Begin);
            this.hpdData.fat2.Initialize();
            binaryWriter.Write(this.hpdData.fat2);
            fs.Seek(1955840L, SeekOrigin.Begin);
            binaryWriter.Write(this.hpdData.oldfont);
            fs.Seek(1998848L, SeekOrigin.Begin);
            binaryWriter.Write(buffer);
            fs.Seek(154140672L, SeekOrigin.Begin);
            binaryWriter.Write(this.hpdData.libfont);
            fileStream.Close();
            fs.Close();
            int num3 = (int) MessageBox.Show("패치가 완료되었습니다");
            this.BackgroundImage = (Image) Resources.main8;
            this.pnl_type.Visible = false;
            this.pnl_type_btn.Visible = false;
          }
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.isofilepath = (string) null;
      this.openFileDialog1.FileName = "";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.isofilepath = this.openFileDialog1.FileName;
      this.label4.Text = this.getName(this.isofilepath);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.isofilepath == null)
        return;
      this.DoPatch(this.isofilepath);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.isofilepath = (string) null;
      this.openFileDialog1.FileName = "";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.isofilepath = this.openFileDialog1.FileName;
      this.label4.Text = this.getName(this.isofilepath);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.DoPatchFont(this.isofilepath);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.mouse_offset.X, this.mouse_offset.Y);
      this.Location = mousePosition;
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
      this.mouse_offset = new Point(-e.X, -e.Y);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      this.BackgroundImage = (Image) Resources.main1;
      this.pnl_type.Visible = false;
      this.pnl_YesorNo.Visible = false;
      this.pnl_type_btn.Visible = false;
    }

    private void btn2_Click(object sender, EventArgs e)
    {
      this.BackgroundImage = (Image) Resources.main2;
      this.pnl_type.Visible = false;
      this.pnl_YesorNo.Visible = false;
      this.pnl_type_btn.Visible = false;
    }

    private void btn3_Click(object sender, EventArgs e)
    {
      this.BackgroundImage = (Image) Resources.main3;
      this.pnl_type.Visible = false;
      this.pnl_YesorNo.Visible = false;
      this.pnl_type_btn.Visible = false;
    }

    private void btn4_Click(object sender, EventArgs e)
    {
      this.BackgroundImage = (Image) Resources.main4;
      this.pnl_type.Visible = false;
      this.pnl_YesorNo.Visible = true;
      this.pnl_type_btn.Visible = false;
    }

    private void check_btn()
    {
      switch (this.Check_btn)
      {
        case 1:
          this.pnl_type.Visible = true;
          this.BackgroundImage = (Image) Resources.main6;
          this.btn_sear.Click -= new EventHandler(this.button6_Click);
          this.btn_sear.Click += new EventHandler(this.button1_Click);
          this.btn_start.Click -= new EventHandler(this.button7_Click);
          this.btn_start.Click += new EventHandler(this.button2_Click);
          this.label4.Text = "";
          this.Check_btn = 3;
          break;
        case 2:
          this.pnl_type.Visible = true;
          this.BackgroundImage = (Image) Resources.main7;
          this.btn_sear.Click -= new EventHandler(this.button1_Click);
          this.btn_sear.Click += new EventHandler(this.button6_Click);
          this.btn_start.Click -= new EventHandler(this.button2_Click);
          this.btn_start.Click += new EventHandler(this.button7_Click);
          this.label4.Text = "";
          this.Check_btn = 4;
          break;
      }
    }

    private void btn_type1_Click(object sender, EventArgs e)
    {
      if (this.Check_btn == 3)
        return;
      this.Check_btn = 1;
      this.check_btn();
    }

    private void btn_type2_Click(object sender, EventArgs e)
    {
      if (this.Check_btn == 4)
        return;
      this.Check_btn = 2;
      this.check_btn();
    }

    private void btn_Yes_Click(object sender, EventArgs e)
    {
      this.BackgroundImage = (Image) Resources.main5;
      this.btn_sear.Click -= new EventHandler(this.button6_Click);
      this.btn_start.Click -= new EventHandler(this.button7_Click);
      this.btn_sear.Click -= new EventHandler(this.button1_Click);
      this.btn_start.Click -= new EventHandler(this.button2_Click);
      this.Check_btn = 0;
      this.pnl_YesorNo.Visible = false;
      this.pnl_type_btn.Visible = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.BackgroundImage = (Image) Resources.main1;
      this.pnl_btn.Visible = true;
      this.timer1.Enabled = false;
    }
  }
}
