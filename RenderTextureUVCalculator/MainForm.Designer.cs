namespace RenderTextureUVCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rawImageWidthTextBox = new System.Windows.Forms.TextBox();
			this.rawImageHeightTextBox = new System.Windows.Forms.TextBox();
			this.renderTextureWidthTextBox = new System.Windows.Forms.TextBox();
			this.renderTextureHeightTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.modelNumTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.uvWidthTextBox = new System.Windows.Forms.TextBox();
			this.uvHeightTextBox = new System.Windows.Forms.TextBox();
			this.uvXTextBox = new System.Windows.Forms.TextBox();
			this.uvYTextBox = new System.Windows.Forms.TextBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "RawImage Width";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(328, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "RawImage Height";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Render Texture Width";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(292, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "Render Texture Height";
			// 
			// rawImageWidthTextBox
			// 
			this.rawImageWidthTextBox.Location = new System.Drawing.Point(162, 52);
			this.rawImageWidthTextBox.Name = "rawImageWidthTextBox";
			this.rawImageWidthTextBox.Size = new System.Drawing.Size(100, 21);
			this.rawImageWidthTextBox.TabIndex = 4;
			this.rawImageWidthTextBox.Text = "266";
			// 
			// rawImageHeightTextBox
			// 
			this.rawImageHeightTextBox.Location = new System.Drawing.Point(429, 52);
			this.rawImageHeightTextBox.Name = "rawImageHeightTextBox";
			this.rawImageHeightTextBox.Size = new System.Drawing.Size(100, 21);
			this.rawImageHeightTextBox.TabIndex = 5;
			this.rawImageHeightTextBox.Text = "362";
			// 
			// renderTextureWidthTextBox
			// 
			this.renderTextureWidthTextBox.Location = new System.Drawing.Point(162, 25);
			this.renderTextureWidthTextBox.Name = "renderTextureWidthTextBox";
			this.renderTextureWidthTextBox.Size = new System.Drawing.Size(100, 21);
			this.renderTextureWidthTextBox.TabIndex = 6;
			this.renderTextureWidthTextBox.Text = "1136";
			// 
			// renderTextureHeightTextBox
			// 
			this.renderTextureHeightTextBox.Location = new System.Drawing.Point(429, 25);
			this.renderTextureHeightTextBox.Name = "renderTextureHeightTextBox";
			this.renderTextureHeightTextBox.Size = new System.Drawing.Size(100, 21);
			this.renderTextureHeightTextBox.TabIndex = 7;
			this.renderTextureHeightTextBox.Text = "640";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(103, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "模型数量";
			// 
			// modelNumTextBox
			// 
			this.modelNumTextBox.Location = new System.Drawing.Point(162, 79);
			this.modelNumTextBox.Name = "modelNumTextBox";
			this.modelNumTextBox.ReadOnly = true;
			this.modelNumTextBox.Size = new System.Drawing.Size(100, 21);
			this.modelNumTextBox.TabIndex = 9;
			this.modelNumTextBox.Text = "3";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.uvYTextBox);
			this.groupBox1.Controls.Add(this.uvXTextBox);
			this.groupBox1.Controls.Add(this.uvHeightTextBox);
			this.groupBox1.Controls.Add(this.uvWidthTextBox);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(12, 133);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 130);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "计算结果";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.calcButton);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.modelNumTextBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.renderTextureHeightTextBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.renderTextureWidthTextBox);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.rawImageHeightTextBox);
			this.groupBox2.Controls.Add(this.rawImageWidthTextBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(600, 115);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "参数设置";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Location = new System.Drawing.Point(12, 269);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(600, 161);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "计算说明";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(268, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 12);
			this.label6.TabIndex = 10;
			this.label6.Text = "(计算单个模型所占宽度)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(109, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 12);
			this.label7.TabIndex = 9;
			this.label7.Text = "UV Rect";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(149, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(11, 12);
			this.label8.TabIndex = 10;
			this.label8.Text = "W";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(288, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(11, 12);
			this.label9.TabIndex = 11;
			this.label9.Text = "H";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(149, 89);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(11, 12);
			this.label10.TabIndex = 12;
			this.label10.Text = "X";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(288, 89);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(11, 12);
			this.label11.TabIndex = 13;
			this.label11.Text = "Y";
			// 
			// uvWidthTextBox
			// 
			this.uvWidthTextBox.Location = new System.Drawing.Point(166, 58);
			this.uvWidthTextBox.Name = "uvWidthTextBox";
			this.uvWidthTextBox.Size = new System.Drawing.Size(100, 21);
			this.uvWidthTextBox.TabIndex = 14;
			// 
			// uvHeightTextBox
			// 
			this.uvHeightTextBox.Location = new System.Drawing.Point(305, 58);
			this.uvHeightTextBox.Name = "uvHeightTextBox";
			this.uvHeightTextBox.Size = new System.Drawing.Size(100, 21);
			this.uvHeightTextBox.TabIndex = 15;
			// 
			// uvXTextBox
			// 
			this.uvXTextBox.Location = new System.Drawing.Point(166, 85);
			this.uvXTextBox.Name = "uvXTextBox";
			this.uvXTextBox.Size = new System.Drawing.Size(100, 21);
			this.uvXTextBox.TabIndex = 16;
			// 
			// uvYTextBox
			// 
			this.uvYTextBox.Location = new System.Drawing.Point(305, 85);
			this.uvYTextBox.Name = "uvYTextBox";
			this.uvYTextBox.Size = new System.Drawing.Size(100, 21);
			this.uvYTextBox.TabIndex = 17;
			// 
			// calcButton
			// 
			this.calcButton.BackColor = System.Drawing.SystemColors.Control;
			this.calcButton.ForeColor = System.Drawing.SystemColors.Highlight;
			this.calcButton.Location = new System.Drawing.Point(429, 78);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(75, 23);
			this.calcButton.TabIndex = 11;
			this.calcButton.Text = "计算";
			this.calcButton.UseVisualStyleBackColor = false;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "计算3D模型在RenderTexture中的UV Rect的WHXY";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox rawImageWidthTextBox;
		private System.Windows.Forms.TextBox rawImageHeightTextBox;
		private System.Windows.Forms.TextBox renderTextureWidthTextBox;
		private System.Windows.Forms.TextBox renderTextureHeightTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox modelNumTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox uvYTextBox;
		private System.Windows.Forms.TextBox uvXTextBox;
		private System.Windows.Forms.TextBox uvHeightTextBox;
		private System.Windows.Forms.TextBox uvWidthTextBox;
		private System.Windows.Forms.Button calcButton;
	}
}

