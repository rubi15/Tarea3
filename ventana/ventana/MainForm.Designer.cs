/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 22/10/2013
 * Time: 08:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ventana
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.Box1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Box2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			// 
			// Box1
			// 
			this.Box1.Location = new System.Drawing.Point(50, 52);
			this.Box1.Name = "Box1";
			this.Box1.Size = new System.Drawing.Size(111, 20);
			this.Box1.TabIndex = 1;
			this.Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// Box2
			// 
			this.Box2.Location = new System.Drawing.Point(50, 125);
			this.Box2.Name = "Box2";
			this.Box2.PasswordChar = '*';
			this.Box2.Size = new System.Drawing.Size(111, 20);
			this.Box2.TabIndex = 3;
			this.Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(98, 187);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Botton1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Box2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Box1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Ventana";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Box2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Box1;
		private System.Windows.Forms.Label label1;
	}
}
