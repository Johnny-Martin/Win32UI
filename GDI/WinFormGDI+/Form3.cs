using System;
using System.Drawing;
using System.Drawing.Text;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GDIPlusDemo
{
	/// <summary>
	/// Form3 的摘要说明。
	/// </summary>
public class Form3 : System.Windows.Forms.Form
{
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.GroupBox groupBox3;
	private System.Windows.Forms.GroupBox groupBox4;
	private System.Windows.Forms.GroupBox groupBox5;
	private System.Windows.Forms.GroupBox groupBox6;
	private System.Windows.Forms.Label label1;
	//字体系列名称列表	
	private System.Windows.Forms.ListBox FontlistBox;
	//五种字体风格的复选框
	private System.Windows.Forms.CheckBox FontStyle_Strikeout;
	private System.Windows.Forms.CheckBox FontStyle_Underline;
	private System.Windows.Forms.CheckBox FontStyle_Italic;
	private System.Windows.Forms.CheckBox FontStyle_Bold;
	private System.Windows.Forms.CheckBox FontStyle_Regular;
	//字体色彩ARGB对应的微调控件	
	private System.Windows.Forms.NumericUpDown FontColor_A;
	private System.Windows.Forms.NumericUpDown FontColor_R;
	private System.Windows.Forms.NumericUpDown FontColor_G;
	private System.Windows.Forms.NumericUpDown FontColor_B;
	//字体大小单位的七个单选按钮
	private System.Windows.Forms.RadioButton FontUnit_Dot;
	private System.Windows.Forms.RadioButton FontUnit_Pixel;
	private System.Windows.Forms.RadioButton FontUnit_Inch;
	private System.Windows.Forms.RadioButton FontUnit_Millimeter;
	private System.Windows.Forms.RadioButton FontUnit_Display;
	private System.Windows.Forms.RadioButton FontUnit_World;
	private System.Windows.Forms.RadioButton FontUnit_Document;
	//字体大小对应的微调控件
	private System.Windows.Forms.NumericUpDown FontSize;
	//字体预览区域
	private System.Windows.Forms.Label FontPreview;

	/// <summary>
	/// 必需的设计器变量。
	/// </summary>
	private System.ComponentModel.Container components = null;

	public Form3()
	{
		//
		// Windows 窗体设计器支持所必需的
		//
		InitializeComponent();

		//
		// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
		//
	}

	/// <summary>
	/// 清理所有正在使用的资源。
	/// </summary>
	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if(components != null)
			{
				components.Dispose();
			}
		}
		base.Dispose( disposing );
	}

	#region Windows 窗体设计器生成的代码
	/// <summary>
	/// 设计器支持所需的方法 - 不要使用代码编辑器修改
	/// 此方法的内容。
	/// </summary>
	private void InitializeComponent()
	{
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.FontStyle_Strikeout = new System.Windows.Forms.CheckBox();
		this.FontStyle_Underline = new System.Windows.Forms.CheckBox();
		this.FontStyle_Italic = new System.Windows.Forms.CheckBox();
		this.FontStyle_Bold = new System.Windows.Forms.CheckBox();
		this.FontStyle_Regular = new System.Windows.Forms.CheckBox();
		this.FontColor_R = new System.Windows.Forms.NumericUpDown();
		this.FontUnit_Dot = new System.Windows.Forms.RadioButton();
		this.FontColor_A = new System.Windows.Forms.NumericUpDown();
		this.FontlistBox = new System.Windows.Forms.ListBox();
		this.FontColor_G = new System.Windows.Forms.NumericUpDown();
		this.FontColor_B = new System.Windows.Forms.NumericUpDown();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.FontUnit_Pixel = new System.Windows.Forms.RadioButton();
		this.FontUnit_Inch = new System.Windows.Forms.RadioButton();
		this.FontUnit_Millimeter = new System.Windows.Forms.RadioButton();
		this.FontUnit_Display = new System.Windows.Forms.RadioButton();
		this.FontUnit_World = new System.Windows.Forms.RadioButton();
		this.FontUnit_Document = new System.Windows.Forms.RadioButton();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.groupBox4 = new System.Windows.Forms.GroupBox();
		this.groupBox5 = new System.Windows.Forms.GroupBox();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox6 = new System.Windows.Forms.GroupBox();
		this.FontSize = new System.Windows.Forms.NumericUpDown();
		this.FontPreview = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_R)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_A)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_G)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_B)).BeginInit();
		this.groupBox3.SuspendLayout();
		this.groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)(this.FontSize)).BeginInit();
		this.SuspendLayout();
		// 
		// groupBox1
		// 
		this.groupBox1.Controls.Add(this.FontStyle_Strikeout);
		this.groupBox1.Controls.Add(this.FontStyle_Underline);
		this.groupBox1.Controls.Add(this.FontStyle_Italic);
		this.groupBox1.Controls.Add(this.FontStyle_Bold);
		this.groupBox1.Controls.Add(this.FontStyle_Regular);
		this.groupBox1.Location = new System.Drawing.Point(160, 72);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(328, 48);
		this.groupBox1.TabIndex = 19;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "设置字体风格";
		// 
		// FontStyle_Strikeout
		// 
		this.FontStyle_Strikeout.Location = new System.Drawing.Point(248, 16);
		this.FontStyle_Strikeout.Name = "FontStyle_Strikeout";
		this.FontStyle_Strikeout.Size = new System.Drawing.Size(64, 24);
		this.FontStyle_Strikeout.TabIndex = 4;
		this.FontStyle_Strikeout.Text = "强调线";
		this.FontStyle_Strikeout.CheckedChanged += new System.EventHandler(this.FontStyle_Strikeout_CheckedChanged);
		// 
		// FontStyle_Underline
		// 
		this.FontStyle_Underline.Location = new System.Drawing.Point(176, 16);
		this.FontStyle_Underline.Name = "FontStyle_Underline";
		this.FontStyle_Underline.Size = new System.Drawing.Size(64, 24);
		this.FontStyle_Underline.TabIndex = 3;
		this.FontStyle_Underline.Text = "下划线";
		this.FontStyle_Underline.CheckedChanged += new System.EventHandler(this.FontStyle_Underline_CheckedChanged);
		// 
		// FontStyle_Italic
		// 
		this.FontStyle_Italic.Location = new System.Drawing.Point(112, 16);
		this.FontStyle_Italic.Name = "FontStyle_Italic";
		this.FontStyle_Italic.Size = new System.Drawing.Size(48, 24);
		this.FontStyle_Italic.TabIndex = 2;
		this.FontStyle_Italic.Text = "倾斜";
		this.FontStyle_Italic.CheckedChanged += new System.EventHandler(this.FontStyle_Italic_CheckedChanged);
		// 
		// FontStyle_Bold
		// 
		this.FontStyle_Bold.Location = new System.Drawing.Point(56, 16);
		this.FontStyle_Bold.Name = "FontStyle_Bold";
		this.FontStyle_Bold.Size = new System.Drawing.Size(48, 24);
		this.FontStyle_Bold.TabIndex = 1;
		this.FontStyle_Bold.Text = "加粗";
		this.FontStyle_Bold.CheckedChanged += new System.EventHandler(this.FontStyle_Bold_CheckedChanged);
		// 
		// FontStyle_Regular
		// 
		this.FontStyle_Regular.Location = new System.Drawing.Point(8, 16);
		this.FontStyle_Regular.Name = "FontStyle_Regular";
		this.FontStyle_Regular.Size = new System.Drawing.Size(48, 24);
		this.FontStyle_Regular.TabIndex = 0;
		this.FontStyle_Regular.Text = "常规";
		this.FontStyle_Regular.CheckedChanged += new System.EventHandler(this.FontStyle_Regular_CheckedChanged);
		// 
		// FontColor_R
		// 
		this.FontColor_R.Location = new System.Drawing.Point(256, 40);
		this.FontColor_R.Name = "FontColor_R";
		this.FontColor_R.Size = new System.Drawing.Size(56, 21);
		this.FontColor_R.TabIndex = 15;
		this.FontColor_R.ValueChanged += new System.EventHandler(this.FontColor_R_ValueChanged);
		// 
		// FontUnit_Dot
		// 
		this.FontUnit_Dot.Location = new System.Drawing.Point(168, 144);
		this.FontUnit_Dot.Name = "FontUnit_Dot";
		this.FontUnit_Dot.Size = new System.Drawing.Size(52, 24);
		this.FontUnit_Dot.TabIndex = 12;
		this.FontUnit_Dot.Text = "点";
		this.FontUnit_Dot.CheckedChanged += new System.EventHandler(this.FontUnit_Dot_CheckedChanged);
		// 
		// FontColor_A
		// 
		this.FontColor_A.Location = new System.Drawing.Point(168, 40);
		this.FontColor_A.Name = "FontColor_A";
		this.FontColor_A.Size = new System.Drawing.Size(56, 21);
		this.FontColor_A.TabIndex = 13;
		this.FontColor_A.ValueChanged += new System.EventHandler(this.FontColor_A_ValueChanged);
		// 
		// FontlistBox
		// 
		this.FontlistBox.ItemHeight = 12;
		this.FontlistBox.Location = new System.Drawing.Point(8, 16);
		this.FontlistBox.Name = "FontlistBox";
		this.FontlistBox.Size = new System.Drawing.Size(136, 244);
		this.FontlistBox.TabIndex = 18;
		this.FontlistBox.SelectedIndexChanged += new System.EventHandler(this.FontlistBox_SelectedIndexChanged);
		// 
		// FontColor_G
		// 
		this.FontColor_G.Location = new System.Drawing.Point(336, 40);
		this.FontColor_G.Name = "FontColor_G";
		this.FontColor_G.Size = new System.Drawing.Size(56, 21);
		this.FontColor_G.TabIndex = 16;
		this.FontColor_G.ValueChanged += new System.EventHandler(this.FontColor_G_ValueChanged);
		// 
		// FontColor_B
		// 
		this.FontColor_B.Location = new System.Drawing.Point(400, 40);
		this.FontColor_B.Name = "FontColor_B";
		this.FontColor_B.Size = new System.Drawing.Size(56, 21);
		this.FontColor_B.TabIndex = 20;
		this.FontColor_B.ValueChanged += new System.EventHandler(this.FontColor_B_ValueChanged);
		// 
		// groupBox2
		// 
		this.groupBox2.Location = new System.Drawing.Point(160, 16);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(328, 56);
		this.groupBox2.TabIndex = 21;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "设置字体色彩（ARGB）";
		// 
		// FontUnit_Pixel
		// 
		this.FontUnit_Pixel.Location = new System.Drawing.Point(320, 144);
		this.FontUnit_Pixel.Name = "FontUnit_Pixel";
		this.FontUnit_Pixel.Size = new System.Drawing.Size(52, 24);
		this.FontUnit_Pixel.TabIndex = 22;
		this.FontUnit_Pixel.Text = "像素";
		this.FontUnit_Pixel.CheckedChanged += new System.EventHandler(this.FontUnit_Pixel_CheckedChanged);
		// 
		// FontUnit_Inch
		// 
		this.FontUnit_Inch.Location = new System.Drawing.Point(240, 144);
		this.FontUnit_Inch.Name = "FontUnit_Inch";
		this.FontUnit_Inch.Size = new System.Drawing.Size(52, 24);
		this.FontUnit_Inch.TabIndex = 23;
		this.FontUnit_Inch.Text = "英寸";
		this.FontUnit_Inch.CheckedChanged += new System.EventHandler(this.FontUnit_Inch_CheckedChanged);
		// 
		// FontUnit_Millimeter
		// 
		this.FontUnit_Millimeter.Location = new System.Drawing.Point(392, 144);
		this.FontUnit_Millimeter.Name = "FontUnit_Millimeter";
		this.FontUnit_Millimeter.Size = new System.Drawing.Size(52, 24);
		this.FontUnit_Millimeter.TabIndex = 24;
		this.FontUnit_Millimeter.Text = "毫米";
		this.FontUnit_Millimeter.CheckedChanged += new System.EventHandler(this.FontUnit_Millimeter_CheckedChanged);
		// 
		// FontUnit_Display
		// 
		this.FontUnit_Display.Location = new System.Drawing.Point(168, 168);
		this.FontUnit_Display.Name = "FontUnit_Display";
		this.FontUnit_Display.Size = new System.Drawing.Size(112, 24);
		this.FontUnit_Display.TabIndex = 25;
		this.FontUnit_Display.Text = "与输出设备相同";
		this.FontUnit_Display.CheckedChanged += new System.EventHandler(this.FontUnit_Display_CheckedChanged);
		// 
		// FontUnit_World
		// 
		this.FontUnit_World.Location = new System.Drawing.Point(392, 168);
		this.FontUnit_World.Name = "FontUnit_World";
		this.FontUnit_World.Size = new System.Drawing.Size(80, 24);
		this.FontUnit_World.TabIndex = 26;
		this.FontUnit_World.Text = "世界坐标";
		this.FontUnit_World.CheckedChanged += new System.EventHandler(this.FontUnit_World_CheckedChanged);
		// 
		// FontUnit_Document
		// 
		this.FontUnit_Document.Location = new System.Drawing.Point(304, 168);
		this.FontUnit_Document.Name = "FontUnit_Document";
		this.FontUnit_Document.Size = new System.Drawing.Size(80, 24);
		this.FontUnit_Document.TabIndex = 27;
		this.FontUnit_Document.Text = "文档单位";
		this.FontUnit_Document.CheckedChanged += new System.EventHandler(this.FontUnit_Document_CheckedChanged);
		// 
		// groupBox3
		// 
		this.groupBox3.Controls.Add(this.groupBox4);
		this.groupBox3.Location = new System.Drawing.Point(160, 128);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(328, 72);
		this.groupBox3.TabIndex = 28;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "选择大小单位";
		// 
		// groupBox4
		// 
		this.groupBox4.Location = new System.Drawing.Point(8, 160);
		this.groupBox4.Name = "groupBox4";
		this.groupBox4.Size = new System.Drawing.Size(328, 72);
		this.groupBox4.TabIndex = 29;
		this.groupBox4.TabStop = false;
		this.groupBox4.Text = "选择大小单位";
		// 
		// groupBox5
		// 
		this.groupBox5.Controls.Add(this.label1);
		this.groupBox5.Controls.Add(this.groupBox6);
		this.groupBox5.Controls.Add(this.FontSize);
		this.groupBox5.Location = new System.Drawing.Point(160, 208);
		this.groupBox5.Name = "groupBox5";
		this.groupBox5.Size = new System.Drawing.Size(328, 56);
		this.groupBox5.TabIndex = 30;
		this.groupBox5.TabStop = false;
		this.groupBox5.Text = "设置字体大小";
		// 
		// label1
		// 
		this.label1.Location = new System.Drawing.Point(24, 24);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(80, 16);
		this.label1.TabIndex = 32;
		this.label1.Text = "字体大小";
		// 
		// groupBox6
		// 
		this.groupBox6.Location = new System.Drawing.Point(8, 160);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(328, 72);
		this.groupBox6.TabIndex = 29;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "选择大小单位";
		// 
		// FontSize
		// 
		this.FontSize.Location = new System.Drawing.Point(120, 24);
		this.FontSize.Name = "FontSize";
		this.FontSize.Size = new System.Drawing.Size(56, 21);
		this.FontSize.TabIndex = 31;
		this.FontSize.Value = new System.Decimal(new int[] {
																1,
																0,
																0,
																0});
		this.FontSize.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
		// 
		// FontPreview
		// 
		this.FontPreview.Location = new System.Drawing.Point(8, 272);
		this.FontPreview.Name = "FontPreview";
		this.FontPreview.Size = new System.Drawing.Size(480, 104);
		this.FontPreview.TabIndex = 31;
		this.FontPreview.Text = "字体示例";
		// 
		// Form3
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
		this.ClientSize = new System.Drawing.Size(496, 382);
		this.Controls.Add(this.FontPreview);
		this.Controls.Add(this.FontUnit_Document);
		this.Controls.Add(this.FontUnit_World);
		this.Controls.Add(this.FontUnit_Display);
		this.Controls.Add(this.FontUnit_Millimeter);
		this.Controls.Add(this.FontUnit_Inch);
		this.Controls.Add(this.FontUnit_Pixel);
		this.Controls.Add(this.FontColor_B);
		this.Controls.Add(this.groupBox1);
		this.Controls.Add(this.FontColor_R);
		this.Controls.Add(this.FontUnit_Dot);
		this.Controls.Add(this.FontColor_A);
		this.Controls.Add(this.FontlistBox);
		this.Controls.Add(this.FontColor_G);
		this.Controls.Add(this.groupBox2);
		this.Controls.Add(this.groupBox3);
		this.Controls.Add(this.groupBox5);
		this.Name = "Form3";
		this.Text = "增强型字体选择对话框";
		this.Load += new System.EventHandler(this.Form3_Load);
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.FontColor_R)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_A)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_G)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.FontColor_B)).EndInit();
		this.groupBox3.ResumeLayout(false);
		this.groupBox5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)(this.FontSize)).EndInit();
		this.ResumeLayout(false);

	}
	#endregion
//字体对话框加载时的初始化处理
private void Form3_Load(object sender, System.EventArgs e)
{
	string tmp=string.Empty;
	//获取所有已经安装的字体系列
	InstalledFontCollection installedFontCollection=new InstalledFontCollection();
	FontFamily[] fontfamily=installedFontCollection.Families;
	int index=0;
	//访问fontfamily数组的每一个成员
	foreach (FontFamily i in fontfamily)
	{
		//在字体列表框中添加字体系列名
		this.FontlistBox.Items.Add(i.Name);
		index++;
	}

	//色彩色彩微调控件的取值范围：最大值
	FontColor_A.Maximum=255;
	FontColor_R.Maximum=255;
	FontColor_G.Maximum=255;
	FontColor_B.Maximum=255;
	//最小值
	FontColor_A.Minimum=0;
	FontColor_R.Minimum=0;
	FontColor_G.Minimum=0;
	FontColor_B.Minimum=0;
	//设置色彩默认值　
	this.FontColor_A.Value=255;
	this.FontColor_R.Value=0;
	this.FontColor_G.Value=0;
	this.FontColor_B.Value=0;
	//字体大小微调控件取值范围
	this.FontSize.Minimum=1;
	this.FontSize.Maximum=100;

	//默认的字体风格为常规
	this.FontStyle_Regular.Checked=true;
	//默认的字体单位为点
	this.FontUnit_Dot.Checked=true;
	//默认的字体大小为12
	this.FontSize.Value=12;
	//默认的字体系列为列表框中的第一个列表项
	this.FontlistBox.SelectedIndex=0;
	this.RedrawFontPreviewWindow();
}

	private void FontlistBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}
//根据用户对字体设置的信息，在预览框中进行字体显示
public void RedrawFontPreviewWindow()
{
	//如果未选择字体系列名称
	if(this.FontlistBox.SelectedIndex==-1)
		return;
	//示例字体输出效果的显示区域　
	Rectangle textOut=new Rectangle(0,0,
		this.FontPreview.Width,this.FontPreview.Height);

	Graphics graphics=this.FontPreview.CreateGraphics();
	graphics.Clear(this.FontPreview.BackColor);
	//获取当前已经选择的字体系列名称及字体大小
	string font_name=this.FontlistBox.Text;
	decimal font_size=this.FontSize.Value;

	//使用灰色线条绘制基准线，以10*10像素为单位
	Pen pen=new Pen(Color.Gray);
	//水平线
	for(int i=0;i<textOut.Height;i+=10)
		graphics.DrawLine(pen,0,i,textOut.Width,i);
	//垂直线
	for(int i=0;i<textOut.Width;i+=10)
		graphics.DrawLine(pen,i,0,i,textOut.Height);

	//获取当前已经选择的字体大小单位
	GraphicsUnit font_uint=GraphicsUnit.Point;
	if(this.FontUnit_Document.Checked)
		font_uint=GraphicsUnit.Document;

	if(this.FontUnit_Inch.Checked)
		font_uint=GraphicsUnit.Inch;

	if(this.FontUnit_Millimeter.Checked)
		font_uint=GraphicsUnit.Millimeter;

	if(this.FontUnit_Pixel.Checked)
		font_uint=GraphicsUnit.Pixel;

	if(this.FontUnit_Dot.Checked)
		font_uint=GraphicsUnit.Point;

	if(this.FontUnit_World.Checked)
		font_uint=GraphicsUnit.World;

	//获取当前已经选择的字体风格
	FontStyle font_style=FontStyle.Regular;
	if(this.FontStyle_Regular.Checked)
		font_style|=FontStyle.Regular;

	if(this.FontStyle_Bold.Checked)
		font_style|=FontStyle.Bold;

	if(this.FontStyle_Italic.Checked)
		font_style|=FontStyle.Italic;

	if(this.FontStyle_Strikeout.Checked)
		font_style|=FontStyle.Strikeout;

	if(this.FontStyle_Underline.Checked)
		font_style|=FontStyle.Underline;

	//获取选择的字体色彩
	Color basecolor=Color.FromArgb((int)this.FontColor_R.Value,
		(int)this.FontColor_G.Value,(int)this.FontColor_B.Value);
	//根据选择的色彩构造输出文本时使用的画刷
	SolidBrush   solidBrush=new SolidBrush(Color.FromArgb((int)this.FontColor_A.Value,basecolor));

	//根据选择的字体信息构造字体
	FontFamily   fontFamily=new FontFamily(font_name);
	Font         font=new Font(fontFamily,
		(int)font_size, (FontStyle)font_style, font_uint);

	//设置文本输出格式：居中
	StringFormat fmt=new StringFormat();
	fmt.Alignment=StringAlignment.Center;
	fmt.LineAlignment=StringAlignment.Center;

	//在字体示意区域输出文本
	graphics.DrawString("GDI+程序设计",font,solidBrush,textOut,fmt);
}

private void FontSize_ValueChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontColor_A_ValueChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontColor_R_ValueChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontColor_G_ValueChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontColor_B_ValueChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontStyle_Regular_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontStyle_Bold_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontStyle_Italic_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontStyle_Underline_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontStyle_Strikeout_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_Dot_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_Inch_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_Pixel_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_Millimeter_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_Display_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_Document_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}

	private void FontUnit_World_CheckedChanged(object sender, System.EventArgs e)
	{
		this.RedrawFontPreviewWindow();
	}
}
}
