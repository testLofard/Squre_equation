/*
 * Created by SharpDevelop.
 * User: oleg
 * Date: 03.06.2018
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sqare
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(9, 10);
			this.textBox1.MaxLength = 5;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(74, 19);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(89, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "x² +";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(203, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "x +";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(131, 10);
			this.textBox2.MaxLength = 5;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(66, 19);
			this.textBox2.TabIndex = 2;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(328, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "= 0";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(252, 10);
			this.textBox3.MaxLength = 5;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(70, 19);
			this.textBox3.TabIndex = 4;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SpringGreen;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(9, 36);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(365, 35);
			this.button1.TabIndex = 6;
			this.button1.Text = "РЕШИТЬ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(9, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(365, 246);
			this.label4.TabIndex = 7;
			this.label4.Text = "Здесь будет решение";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(385, 335);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "sqare";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
