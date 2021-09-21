using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarkLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = tb.Text;

                var arr = input.Split(',');

              

                var newText = "";

                foreach(var num in arr)
                {
                    var totalTime = Convert.ToInt32(num);

                    int minutes = totalTime / 1000 / 60;
                    int minMili = minutes * 1000 * 60;
                    int seconds = (totalTime - minMili) / 1000;
                    int secMili = seconds * 1000;
                    int miliseconds = totalTime - minMili - secMili;

                    var formatted = $"{minutes}:{seconds}:{miliseconds}";
                    newText = newText + Environment.NewLine + formatted + " -";
                }
                tb.Clear();
                tb.Text = newText;
                Error.Visible = false;
            }
            catch
            {
                Error.Visible = true;
                Error.Text = $"There was an error, please check if the input has \n\t any unnessesary spaces or letters.";
            }

            


        }
    }
}
