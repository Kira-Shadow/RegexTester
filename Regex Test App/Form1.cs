using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Test_App
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();



            // asdf, aaaaa gdsgds fdgs iofdsjfsdjif fdjioasf fdsjaof fsdjaofj fdsuyaofud rrrr, dfsijfjoi fdsaf fdsopapfosd,  fdaf fdsji ddijdi

            tbfont.Value = (int)rt1.Font.Size;

            Update();
        }

        bool norentry = false;

        void Update()
        {

            if (norentry) return;

            norentry = true;

            int i = rt1.SelectionStart;
            int l = rt1.SelectionLength;

            rt1.SelectAll();
            rt1.SelectionBackColor = Color.White;
            rt1.SelectionColor = Color.FromArgb(100, 100, 100);
            rt1.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", tbfont.Value, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEx.Text = "";
            try
            {
                var r = new Regex(rtRegex.Text,
                    (chkCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None) |
                    (chkMulti.Checked ? RegexOptions.Multiline : 0) |
                    (chkExplicit.Checked ? RegexOptions.ExplicitCapture : 0) |
                    (chkSingle.Checked ? RegexOptions.Singleline : 0) |
                    (chkIgnoreWS.Checked ? RegexOptions.IgnorePatternWhitespace : 0)
                    );

                var m = r.Matches(rt1.Text);



                foreach (Match g1 in m)
                {
                    Debug.WriteLine(g1);
                    rt1.Select(g1.Index, g1.Length);
                    rt1.SelectionFont= new System.Drawing.Font("Microsoft Sans Serif", tbfont.Value, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    rt1.SelectionColor = Color.Black;
                     
                    //rt1.SelectionBackColor = Color.Red;

                }
            }
            catch (Exception ex)
            {
                lblEx.Text = ex.Message;
            }

            rt1.Select(i, l);

            timer1.Stop();
            norentry = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 1000;
            timer1.Start();


        }

        private void rtRegex_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Update();
            norentry = false;
        }

        private void chkCase_CheckedChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbfont_Scroll(object sender, EventArgs e)
        {
            rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", tbfont.Value, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rtRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", tbfont.Value, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
