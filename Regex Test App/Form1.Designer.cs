
namespace Regex_Test_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.rtRegex = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEx = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIgnoreWS = new System.Windows.Forms.CheckBox();
            this.chkSingle = new System.Windows.Forms.CheckBox();
            this.chkExplicit = new System.Windows.Forms.CheckBox();
            this.chkMulti = new System.Windows.Forms.CheckBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.tbfont = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbfont)).BeginInit();
            this.SuspendLayout();
            // 
            // rt1
            // 
            this.rt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt1.Location = new System.Drawing.Point(27, 330);
            this.rt1.Margin = new System.Windows.Forms.Padding(2);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(913, 294);
            this.rt1.TabIndex = 0;
            this.rt1.Text = "";
            this.rt1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rtRegex
            // 
            this.rtRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtRegex.Location = new System.Drawing.Point(27, 23);
            this.rtRegex.Margin = new System.Windows.Forms.Padding(2);
            this.rtRegex.Name = "rtRegex";
            this.rtRegex.Size = new System.Drawing.Size(757, 303);
            this.rtRegex.TabIndex = 1;
            this.rtRegex.Text = "";
            this.rtRegex.TextChanged += new System.EventHandler(this.rtRegex_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(24, 629);
            this.lblEx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(0, 13);
            this.lblEx.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkIgnoreWS);
            this.groupBox1.Controls.Add(this.chkSingle);
            this.groupBox1.Controls.Add(this.chkExplicit);
            this.groupBox1.Controls.Add(this.chkMulti);
            this.groupBox1.Controls.Add(this.chkCase);
            this.groupBox1.Location = new System.Drawing.Point(788, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(151, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // chkIgnoreWS
            // 
            this.chkIgnoreWS.AutoSize = true;
            this.chkIgnoreWS.Location = new System.Drawing.Point(16, 91);
            this.chkIgnoreWS.Margin = new System.Windows.Forms.Padding(2);
            this.chkIgnoreWS.Name = "chkIgnoreWS";
            this.chkIgnoreWS.Size = new System.Drawing.Size(121, 17);
            this.chkIgnoreWS.TabIndex = 11;
            this.chkIgnoreWS.Text = "Ignore White Space";
            this.chkIgnoreWS.UseVisualStyleBackColor = true;
            this.chkIgnoreWS.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
            // 
            // chkSingle
            // 
            this.chkSingle.AutoSize = true;
            this.chkSingle.Location = new System.Drawing.Point(16, 72);
            this.chkSingle.Margin = new System.Windows.Forms.Padding(2);
            this.chkSingle.Name = "chkSingle";
            this.chkSingle.Size = new System.Drawing.Size(101, 17);
            this.chkSingle.TabIndex = 10;
            this.chkSingle.Text = "Singleline Mode";
            this.chkSingle.UseVisualStyleBackColor = true;
            this.chkSingle.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
            // 
            // chkExplicit
            // 
            this.chkExplicit.AutoSize = true;
            this.chkExplicit.Location = new System.Drawing.Point(16, 54);
            this.chkExplicit.Margin = new System.Windows.Forms.Padding(2);
            this.chkExplicit.Name = "chkExplicit";
            this.chkExplicit.Size = new System.Drawing.Size(59, 17);
            this.chkExplicit.TabIndex = 9;
            this.chkExplicit.Text = "Explicit";
            this.chkExplicit.UseVisualStyleBackColor = true;
            this.chkExplicit.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
            // 
            // chkMulti
            // 
            this.chkMulti.AutoSize = true;
            this.chkMulti.Location = new System.Drawing.Point(16, 35);
            this.chkMulti.Margin = new System.Windows.Forms.Padding(2);
            this.chkMulti.Name = "chkMulti";
            this.chkMulti.Size = new System.Drawing.Size(93, 17);
            this.chkMulti.TabIndex = 8;
            this.chkMulti.Text = "Multiline mode";
            this.chkMulti.UseVisualStyleBackColor = true;
            this.chkMulti.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(16, 16);
            this.chkCase.Margin = new System.Windows.Forms.Padding(2);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(102, 17);
            this.chkCase.TabIndex = 7;
            this.chkCase.Text = "Case insensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            this.chkCase.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
            // 
            // tbfont
            // 
            this.tbfont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbfont.Location = new System.Drawing.Point(660, 629);
            this.tbfont.Maximum = 20;
            this.tbfont.Minimum = 8;
            this.tbfont.Name = "tbfont";
            this.tbfont.Size = new System.Drawing.Size(246, 45);
            this.tbfont.TabIndex = 9;
            this.tbfont.Value = 8;
            this.tbfont.Scroll += new System.EventHandler(this.tbfont_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 665);
            this.Controls.Add(this.tbfont);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.rtRegex);
            this.Controls.Add(this.rt1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Regex Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbfont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.RichTextBox rtRegex;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIgnoreWS;
        private System.Windows.Forms.CheckBox chkSingle;
        private System.Windows.Forms.CheckBox chkExplicit;
        private System.Windows.Forms.CheckBox chkMulti;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.TrackBar tbfont;
    }
}

