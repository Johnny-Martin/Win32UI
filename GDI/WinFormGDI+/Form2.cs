using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GDIPlusDemo
{
	/// <summary>
	/// Form2 的摘要说明。
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		Bitmap animatedImage = new Bitmap("SampleAnimation.gif");

		bool currentlyAnimating = false;

		//This method begins the animation.

		public void AnimateImage() 
		{

			if (!currentlyAnimating) 
			{

				//Begin the animation only once.

				ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));

				currentlyAnimating = true;

			}
		}


		public Form2()
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
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(664, 390);
			this.Name = "Form2";
			this.Text = "显示GIF文件";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);

		}
		#endregion

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
		}

		
		
		private void OnFrameChanged(object o, EventArgs e) 
		{

			//Force a call to the Paint event handler.

			this.Invalidate();

		}


		private void Form2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			//Begin the animation.

			AnimateImage();

			//Get the next frame ready for rendering.

			ImageAnimator.UpdateFrames();

			//Draw the next frame in the animation.

			e.Graphics.DrawImage(this.animatedImage, new Point(0, 0));

		}
	}
}
