
/*
 * Created by SharpDevelop.
 * User: oleg
 * Date: 03.06.2018
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sqare
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty) ){
				label4.Text = "Значения не введены ";
				
			}
			else{
				
				if (textBox1.Text == "Марка"){
					
					Form F = new Form1();
					F.Show();
					
				}
				
				else{
				try{
					
					double a = Convert.ToDouble(textBox1.Text);
					try {
						
						double b = Convert.ToDouble(textBox2.Text);
						try {
							
							double c = Convert.ToDouble(textBox3.Text);
							
							if (a == 0){
								
								if (b == 0){
									
									if (c == 0){
										
										label4.Text = "Любой Х";
										
									}
									
									else{
										
										label4.Text = "0*x = " + (-c);
										
									}
								}
								
								else{
									double x = -c/b;
									label4.Text = "x = -(" + c +")/"+ b + " = " + x;
									
								}
							}
							else{
								double D = (Math.Pow(b,2))-(4*a*c);
								if (D < 0){
									
									label4.Text = "D = " + b + "^2 - 4 * " + a + "*" + c + " = " + D + "\n\nРешений нет";
								
								}
				
								if (D == 0){
									
									double x1 = ((b)*(-1))/(2*a);
									label4.Text = "D = " + b + "^2 - 4 * " + a + " * " + c + " = " + D + "\n\n" + 
									"x1,x2 = (" + b + ")/(2*" + a + ") = " + x1;
					
								}
								
								if (D > 0){
					
									double x1 = Math.Round(((-b) + Math.Sqrt(D))/(2*a) , 2);
									double x2 = Math.Round(((-b) - Math.Sqrt(D))/(2*a) , 2);
									label4.Text = "D = " + b + "^2 - 4 * " + a + " * " + c + " = " + D + "\n\n" +
									"x1 = (-(" + b + ") + √"+D+")/(2 * " + a + ") = " + x1 + "\n\n" +
									"x2 = (-(" + b + ") - √"+D+")/(2 * " + a + ") = " + x2;
								}
							
							}	 
						}
						
						catch (Exception) {
							
							label4.Text = "Поле 3 некорректно";
						
						}
						
					} 
					
					catch (Exception) {
						
						label4.Text = "Поле 2 некорректно";
						
					}
					
				}
				
				catch(Exception){
					
					label4.Text = "Поле 1 некорректно";
					
				}
				
				
			}
			}
		}
	}
}
