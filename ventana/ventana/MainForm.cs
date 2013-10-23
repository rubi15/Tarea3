
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ventana
{
	
	public partial class MainForm : Form
	{
		string Usuario = "rubi";
		string Password= "rubiicitha";
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Botton1Click(object sender, EventArgs e)
		{
			if(Box1.Text == Usuario && Box2.Text==Password){
				
				MessageBox.Show("Hola");
			}else
				MessageBox.Show("Error, \n Su Usuario o Password son incorrectos.");
		}
	}
}
