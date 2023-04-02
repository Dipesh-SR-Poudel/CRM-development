namespace CRM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.PeachPuff;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 451);
            this.panel1.TabIndex = 1;
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.Color.White;
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.White;
            this.bunifuAppBar1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuAppBar1.Icon")));
            this.bunifuAppBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(908, 46);
            this.bunifuAppBar1.TabIndex = 2;
            this.bunifuAppBar1.Title = "Application Title";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            this.bunifuAppBar1.IconClick += new System.EventHandler(this.bunifuAppBar1_IconClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuAppBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Utils.BunifuAppBar bunifuAppBar1;
    }
}

