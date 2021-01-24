using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Keyword_Generator_Project_AM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		//Coded project AM
        private void button1_Click(object sender, EventArgs e)
        {
			Process.Start("https://www.youtube.com/watch?v=0Z0RMxlcmHs");
			string text = this.textBox1.Text;
			HtmlElement htmlElement = this.webBrowser1.Document.All["input"];
			bool flag = htmlElement != null;
			if (flag)
			{
				htmlElement.InnerText = text;
			}
			this.webBrowser1.Document.GetElementById("startjob").InvokeMember("click");
			string text2 = "Gathering started! \n Wait some seconds, than press Stop!";
			MessageBox.Show(text2);
			Task.Factory.StartNew(delegate ()
			{
				for (int i = 0; i < 500; i++)
				{
					base.Invoke(new MethodInvoker(delegate ()
					{
						HtmlElement htmlElement2 = this.webBrowser1.Document.All["numofkeywords"];
						//this.label4.Text = htmlElement2.InnerText;
						toolStripStatusLabel2.Text = htmlElement2.InnerText;
					}));
					Thread.Sleep(100);
				}
			});
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Process.Start("https://www.youtube.com/watch?v=0Z0RMxlcmHs");
			try
            {
				HtmlElement htmlElement = this.webBrowser1.Document.All["input"];
				this.richTextBox1.Text = htmlElement.InnerText;
				this.webBrowser1.Document.GetElementById("startjob").InvokeMember("click");
				HtmlElement htmlElement2 = this.webBrowser1.Document.All["numofkeywords"];
				//this.label4.Text = htmlElement2.InnerText;
				toolStripStatusLabel2.Text = htmlElement2.InnerText;


				foreach (string input in richTextBox1.Lines)
				{

					listView1.Items.Add(input);
				}

			}
			 catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
            }

           


		}

		private void button3_Click(object sender, EventArgs e)
        {
			Process.Start("https://www.youtube.com/watch?v=0Z0RMxlcmHs");
			try
            {
				const string sPath = "Keyword's.txt";
				TextWriter SaveFile = new StreamWriter(sPath);
				SaveFile.Write(this.richTextBox1.Text);
				SaveFile.Close();
				string text = "Keyword's saved!";
				MessageBox.Show(text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}











		}

		private void Form1_Load(object sender, EventArgs e)
        {
			Process.Start("https://www.youtube.com/watch?v=0Z0RMxlcmHs");
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
			
		}
    }
}
