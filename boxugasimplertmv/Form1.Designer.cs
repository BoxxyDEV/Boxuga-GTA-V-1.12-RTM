
namespace boxugasimplertmv
{
    partial class boxugasimplertmv
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
            this.connect = new System.Windows.Forms.GroupBox();
            this.attachps3 = new System.Windows.Forms.Button();
            this.connectbtn = new System.Windows.Forms.Button();
            this.toolsgroup = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namechangebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.connect.SuspendLayout();
            this.toolsgroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Controls.Add(this.attachps3);
            this.connect.Controls.Add(this.connectbtn);
            this.connect.Location = new System.Drawing.Point(13, 13);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(200, 57);
            this.connect.TabIndex = 0;
            this.connect.TabStop = false;
            this.connect.Text = "Connect / Attach";
            // 
            // attachps3
            // 
            this.attachps3.Location = new System.Drawing.Point(119, 19);
            this.attachps3.Name = "attachps3";
            this.attachps3.Size = new System.Drawing.Size(75, 23);
            this.attachps3.TabIndex = 3;
            this.attachps3.Text = "Attach";
            this.attachps3.UseVisualStyleBackColor = true;
            this.attachps3.Click += new System.EventHandler(this.attachps3_Click);
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(7, 19);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 2;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // toolsgroup
            // 
            this.toolsgroup.Controls.Add(this.checkBox1);
            this.toolsgroup.Controls.Add(this.groupBox1);
            this.toolsgroup.Enabled = false;
            this.toolsgroup.Location = new System.Drawing.Point(13, 76);
            this.toolsgroup.Name = "toolsgroup";
            this.toolsgroup.Size = new System.Drawing.Size(200, 130);
            this.toolsgroup.TabIndex = 1;
            this.toolsgroup.TabStop = false;
            this.toolsgroup.Text = "Tools";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Sonic Speed (Glitchy)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namechangebox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name Changer";
            // 
            // namechangebox
            // 
            this.namechangebox.Location = new System.Drawing.Point(6, 19);
            this.namechangebox.MaxLength = 20;
            this.namechangebox.Name = "namechangebox";
            this.namechangebox.Size = new System.Drawing.Size(169, 20);
            this.namechangebox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxugasimplertmv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 268);
            this.Controls.Add(this.toolsgroup);
            this.Controls.Add(this.connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "boxugasimplertmv";
            this.Text = "Boxuga\'s bad RTM Tool (GTA V 1.12)";
            this.Load += new System.EventHandler(this.boxugasimplertmv_Load);
            this.connect.ResumeLayout(false);
            this.toolsgroup.ResumeLayout(false);
            this.toolsgroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connect;
        private System.Windows.Forms.Button attachps3;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.GroupBox toolsgroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox namechangebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

