using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RenderTextureUVCalculator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			float rtW = float.Parse(renderTextureWidthTextBox.Text);
			float rtH = float.Parse(renderTextureHeightTextBox.Text);

			float imgW = float.Parse(rawImageWidthTextBox.Text);
			float imgH = float.Parse(rawImageHeightTextBox.Text);
			
			float uvW = imgW / rtW;
			float uvH = imgH / rtH;

			float uvX = (1f - uvW) * .5f;
			float uvY = (1f - uvH) * .5f;

			uvWidthTextBox.Text = uvW.ToString("f6");
			uvHeightTextBox.Text = uvH.ToString("f6");

			uvXTextBox.Text = uvX.ToString("f6");
			uvYTextBox.Text = uvY.ToString("f6");
		}
	}
}
