using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TenisOyunu
{
 /// <summary>
 /// Summary description for Form1.
 /// </summary>
 public class Form1 : System.Windows.Forms.Form
 {
  internal System.Windows.Forms.Label label4;
  internal System.Windows.Forms.Timer timer2;
  internal System.Windows.Forms.Timer timer1;
  internal System.Windows.Forms.Label label3;
  internal System.Windows.Forms.Label label2;
  internal System.Windows.Forms.Label label1;
  internal System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.Button button1;
  internal System.Windows.Forms.ImageList ýmageList1;
  internal System.Windows.Forms.ImageList ýmageList2;
  private System.ComponentModel.IContainer components;

  public Form1()
  {
   //
   // Required for Windows Form Designer support
   //
   InitializeComponent();

   //
   // TODO: Add any constructor code after InitializeComponent call
   //
  }

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  protected override void Dispose( bool disposing )
  {
   if( disposing )
   {
    if (components != null) 
    {
     components.Dispose();
    }
   }
   base.Dispose( disposing );
  }

		#region Windows Form Designer generated code
  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.components = new System.ComponentModel.Container();
   System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
   this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
   this.label4 = new System.Windows.Forms.Label();
   this.timer2 = new System.Windows.Forms.Timer(this.components);
   this.timer1 = new System.Windows.Forms.Timer(this.components);
   this.label3 = new System.Windows.Forms.Label();
   this.ýmageList2 = new System.Windows.Forms.ImageList(this.components);
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.button1 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // ýmageList1
   // 
   this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList1.ImageSize = new System.Drawing.Size(16, 16);
   this.ýmageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList1.ImageStream")));
   this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // label4
   // 
   this.label4.Location = new System.Drawing.Point(584, 312);
   this.label4.Name = "label4";
   this.label4.TabIndex = 11;
   this.label4.Text = "label4";
   // 
   // timer2
   // 
   this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
   // 
   // timer1
   // 
   this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
   // 
   // label3
   // 
   this.label3.Location = new System.Drawing.Point(448, 312);
   this.label3.Name = "label3";
   this.label3.TabIndex = 10;
   this.label3.Text = "label3";
   // 
   // ýmageList2
   // 
   this.ýmageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
   this.ýmageList2.ImageSize = new System.Drawing.Size(16, 16);
   this.ýmageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ýmageList2.ImageStream")));
   this.ýmageList2.TransparentColor = System.Drawing.Color.Transparent;
   // 
   // label2
   // 
   this.label2.Location = new System.Drawing.Point(208, 304);
   this.label2.Name = "label2";
   this.label2.TabIndex = 9;
   this.label2.Text = "label2";
   // 
   // label1
   // 
   this.label1.Location = new System.Drawing.Point(72, 304);
   this.label1.Name = "label1";
   this.label1.TabIndex = 8;
   this.label1.Text = "label1";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(72, 136);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(16, 16);
   this.pictureBox1.TabIndex = 7;
   this.pictureBox1.TabStop = false;
   // 
   // button1
   // 
   this.button1.Location = new System.Drawing.Point(64, 240);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(120, 32);
   this.button1.TabIndex = 6;
   this.button1.Text = "button1";
   this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
   // 
   // Form1
   // 
   this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
   this.ClientSize = new System.Drawing.Size(696, 342);
   this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                              this.pictureBox1,
                                                              this.button1,
                                                              this.label4,
                                                              this.label3,
                                                              this.label2,
                                                              this.label1});
   this.Name = "Form1";
   this.Text = "Form1";
   this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
   this.Load += new System.EventHandler(this.Form1_Load);
   this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
   this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
   this.ResumeLayout(false);

  }
		#endregion

  /// <summary>
  /// The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main() 
  {
   Application.Run(new Form1());
  }

  int satirsayisi, sutunsayisi, kutusayisi, puan, level ;
  int xa, ya;
  Boolean demo=false;
  int[] kutu;

  void yenioyun()
  {
   int i, j;
   satirsayisi = satirsayisi + 1;
   sutunsayisi = sutunsayisi + 1;
   kutusayisi = satirsayisi * sutunsayisi;
   kutu=new int[kutusayisi];
   xa = 10;
   ya = -10;
   this.pictureBox1.Top = this.button1.Top - 100;
   this.label3.Text = "Level " + level;
   this.Width = 60 * sutunsayisi + 8;
   Random r =new Random((int)(System.DateTime.Now.Ticks % System.Int32.MaxValue));
   this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
   //Her seviyede raketin geniþliðini azalt
   this.button1.Width = this.button1.Width - 10;
   //Kutularý oluþtur
   for (i = 0; i<=kutusayisi - 1;i++)
    kutu[i] = (int) (r.Next(6)) + 1;//Kutulara rasgele resim numarasý yerleþtir
   //Kutulara rasgele bomba yerleþtir
   for(i = 0 ; i<=kutusayisi / 5 ;i++)
   {
    j = r.Next(kutusayisi);
    kutu[j] = 200; //200=bomba
   }
   this.label4.Text = "Level " + level;
   //labeli ortala
   this.label4.Left = (this.ClientSize.Width - this.label4.Width) / 2;
   this.label4.Top = (this.ClientSize.Height - this.label4.Height) / 2;
   this.label4.Visible = true;
   Application.DoEvents();
   System.Threading.Thread.Sleep(2000); //2 saniye beklet
   this.label4.Visible = false;
  }

  private void Form1_Load(object sender, System.EventArgs e)
  {
   this.Text = "Tenis";
   Show();
   KeyPreview = true;
   level = 1;
   satirsayisi = 4;
   sutunsayisi = 4;
   button1.Text = "";
   button1.Top = this.ClientSize.Height - 100;
   label1.AutoSize = true;
   label2.AutoSize = true;
   label3.AutoSize = true;
   label4.AutoSize = true;
   label4.Font = new Font("Tahoma", 14, FontStyle.Bold);
   label1.Text = "0";
   label1.Top = ClientSize.Height - label1.Height;
   label1.Left = 0;
   label2.Text = "KutuSayýsý";
   label2.Top = ClientSize.Height - label2.Height;
   label2.Left = label1.Left + label2.Width + 10;
   label3.Text = "Level 1";
   label3.Top = ClientSize.Height - label3.Height;
   label3.Left = label2.Left + label2.Width + 10;
   pictureBox1.Width = 16;
   pictureBox1.Height = 16;
   yenioyun();
   timer1.Interval = 50;
   timer1.Enabled = true;
   timer2.Enabled = true;
  }

  int resim_no=0;
  private void timer2_Tick(object sender, System.EventArgs e)
  {
   resim_no++;
   resim_no = resim_no % 8;
   pictureBox1.Image = ýmageList1.Images[resim_no];
  }

  private void button1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if ((kutusayisi != 1) && (demo==false)) 
    button1.Left = button1.Left + e.X;
  }

  private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
  {
   if ((kutusayisi != 1) && (demo==false))
    button1.Left = e.X;
  }

  private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
  {
   int i, ks=0;
   SolidBrush b =new SolidBrush(Color.White);
   for (i = 0;i<= satirsayisi * sutunsayisi - 1;i++)
   {
    float x, y;
    x = 60 * (i % sutunsayisi);
    y = 20 * (int) (i / sutunsayisi);
    if (kutu[i] != 100)
    {
     //Kutu varsa rasgele renkle boya
     Random r =new Random((int)(System.DateTime.Now.Ticks % System.Int32.MaxValue));
     b.Color  = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
     ks++;
     e.Graphics.FillRectangle(b, x, y, 60, 20);
     e.Graphics.DrawRectangle(new Pen(this.BackColor), x, y, 60, 20);
     if (kutu[i] != 200) //bomba varsa resim koyma
      ýmageList2.Draw(e.Graphics, (int)x + 22, (int)y + 2, kutu[i] - 1);
    }
    else
    {
     //Kutu yoksa zemin rengine boya
     b.Color = this.BackColor;
     e.Graphics.FillRectangle(b, x, y, 60, 20);
    }
   }
   kutusayisi = ks;
   label2.Text = kutusayisi.ToString();
  }

  private void timer1_Tick(object sender, System.EventArgs e)
  {
   int i, j, k, m, n, s;
   //sol kenara gelince geri dön
   if (pictureBox1.Left <= 0) 
   {
    xa = -xa ;
    pictureBox1.Left = 0;
   }
   //sað kenara gelince geri dön
   if (pictureBox1.Right >= ClientSize.Width)
    xa = -xa;
   //üst kenara gelince geri dön
   if (pictureBox1.Top <= 0)
   {
    ya = -ya;
    pictureBox1.Top = 0;
   }
   //Button1 ile çarpýþtýysa geri dön
   if ((pictureBox1.Top >= button1.Top) && (pictureBox1.Top < button1.Bottom) && (pictureBox1.Left > button1.Left) && (pictureBox1.Left < button1.Right))
    ya = -ya;
   //formun altýnda geldiyse bitir
   if (pictureBox1.Top >= ClientSize.Height)
   {
    timer1.Enabled = false;
    MessageBox.Show("Oyun bitti");
   }
   pictureBox1.Left += xa;
   pictureBox1.Top += ya;
   //koordinatlara denk gelen kutuyu bul
   i = (int) (pictureBox1.Left + pictureBox1.Width / 2) / 60;
   j = (int) pictureBox1.Top / 20;
   k = j * sutunsayisi + i;
   if ((j <= satirsayisi - 1) && (i <= sutunsayisi - 1))
   {
    //Koordinatlarda bir kutu varsa
    if (kutu[k] != 100) //Kutu daha önce vurulmamýþsa 
    {
     Graphics g ;
     g = this.CreateGraphics();
     kutusayisi = kutusayisi - 1;
     puan = puan + 10 * kutu[k];
     label1.Text = puan.ToString();
     //Puaný yaz
     g.DrawString((kutu[k] * 10).ToString(), 
      new Font("Tahoma", 10, FontStyle.Bold), 
      new SolidBrush(Color.White), 
      60 * (k % sutunsayisi) + 10, 
      20 * (k / sutunsayisi) + 5);
     System.Threading.Thread.Sleep(100);
     ya = -ya; //kutuya çarptýðý için geri dönsün
     if (kutu[k] == 200)//bomba
     {
      //Etrafýndakileri yok et
      for (m = i;m<=i + 2;m++)
       for (n = j - 1;n<=j + 1;n++)
       {
        s = n * sutunsayisi + m - 1;
        //kutu varsa yok et
        if ((s >= 0) && (n <= satirsayisi - 1) && (m <= sutunsayisi - 1))
        {
         kutu[s] = 100;
         g.DrawString("Boomm!", 
          new Font("Tahoma", 10, FontStyle.Bold), 
          new SolidBrush(Color.White), 
          60 * (s % sutunsayisi), 
          20 * (s / sutunsayisi));
         System.Threading.Thread.Sleep(100);
        }
       }
     }
     kutu[k] = 100;
     this.Invalidate(); //Paint olayýnýn çalýþýp yeniden çizim yapmasý için
     g.Dispose();
    }
   }
   //Bir kutu kalýrsa otomatik oynat
   if ((kutusayisi == 1) || (demo==true))
   {
    button1.Left = pictureBox1.Left - (button1.Width / 2);
    button1.Text = "Auto Pilot";
   }
   else
    button1.Text = "";
   //Kutu bittiyse yeni oyuna geç
   if (kutusayisi == 0)
   {
    level++;
    yenioyun();
    }
  }

  private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
  {
   //esc tuþuna basýlýrsa demo moduna geçir
  if (e.KeyChar == (char)27)  demo = !demo;
  }
 }
}
