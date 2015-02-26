namespace Infamous_Gamerz_Trainer
{
	partial class hMainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hMainWindow));
            this.hProcess_Group = new System.Windows.Forms.GroupBox();
            this.hProcess_Status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hSearchForProcess = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memadjustable1freeze = new System.Windows.Forms.Button();
            this.memadjustable1 = new System.Windows.Forms.TextBox();
            this.memoryedit3 = new System.Windows.Forms.Button();
            this.memoryedit2 = new System.Windows.Forms.Button();
            this.memoryedit1 = new System.Windows.Forms.Button();
            this.iglink = new System.Windows.Forms.LinkLabel();
            this.hProcess_Group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hProcess_Group
            // 
            this.hProcess_Group.Controls.Add(this.hProcess_Status);
            this.hProcess_Group.Controls.Add(this.label5);
            this.hProcess_Group.Location = new System.Drawing.Point(12, 12);
            this.hProcess_Group.Name = "hProcess_Group";
            this.hProcess_Group.Size = new System.Drawing.Size(296, 54);
            this.hProcess_Group.TabIndex = 14;
            this.hProcess_Group.TabStop = false;
            this.hProcess_Group.Text = "Process";
            // 
            // hProcess_Status
            // 
            this.hProcess_Status.Location = new System.Drawing.Point(48, 21);
            this.hProcess_Status.MaxLength = 5;
            this.hProcess_Status.Name = "hProcess_Status";
            this.hProcess_Status.ReadOnly = true;
            this.hProcess_Status.Size = new System.Drawing.Size(242, 20);
            this.hProcess_Status.TabIndex = 16;
            this.hProcess_Status.Text = "Searching for Process...";
            this.hProcess_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status:";
            // 
            // hSearchForProcess
            // 
            this.hSearchForProcess.Enabled = true;
            this.hSearchForProcess.Tick += new System.EventHandler(this.hSearchForProcess_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memadjustable1freeze);
            this.groupBox1.Controls.Add(this.memadjustable1);
            this.groupBox1.Controls.Add(this.memoryedit3);
            this.groupBox1.Controls.Add(this.memoryedit2);
            this.groupBox1.Controls.Add(this.memoryedit1);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheats";
            // 
            // memadjustable1freeze
            // 
            this.memadjustable1freeze.Location = new System.Drawing.Point(109, 48);
            this.memadjustable1freeze.Name = "memadjustable1freeze";
            this.memadjustable1freeze.Size = new System.Drawing.Size(75, 23);
            this.memadjustable1freeze.TabIndex = 4;
            this.memadjustable1freeze.Text = "Freeze On";
            this.memadjustable1freeze.UseVisualStyleBackColor = true;
            this.memadjustable1freeze.Click += new System.EventHandler(this.memadjustable1freeze_Click);
            // 
            // memadjustable1
            // 
            this.memadjustable1.Location = new System.Drawing.Point(3, 48);
            this.memadjustable1.Name = "memadjustable1";
            this.memadjustable1.Size = new System.Drawing.Size(100, 20);
            this.memadjustable1.TabIndex = 3;
            this.memadjustable1.Text = "0";
            this.memadjustable1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.memadjustable1.TextChanged += new System.EventHandler(this.memadjustable1_TextChanged);
            // 
            // memoryedit3
            // 
            this.memoryedit3.Location = new System.Drawing.Point(215, 16);
            this.memoryedit3.Name = "memoryedit3";
            this.memoryedit3.Size = new System.Drawing.Size(75, 23);
            this.memoryedit3.TabIndex = 2;
            this.memoryedit3.Text = "Hack On";
            this.memoryedit3.UseVisualStyleBackColor = true;
            this.memoryedit3.Click += new System.EventHandler(this.memoryedit3_Click);
            // 
            // memoryedit2
            // 
            this.memoryedit2.Location = new System.Drawing.Point(109, 16);
            this.memoryedit2.Name = "memoryedit2";
            this.memoryedit2.Size = new System.Drawing.Size(75, 23);
            this.memoryedit2.TabIndex = 1;
            this.memoryedit2.Text = "Hack On";
            this.memoryedit2.UseVisualStyleBackColor = true;
            this.memoryedit2.Click += new System.EventHandler(this.memoryedit2_Click);
            // 
            // memoryedit1
            // 
            this.memoryedit1.Location = new System.Drawing.Point(3, 16);
            this.memoryedit1.Name = "memoryedit1";
            this.memoryedit1.Size = new System.Drawing.Size(75, 23);
            this.memoryedit1.TabIndex = 0;
            this.memoryedit1.Text = "Hack On";
            this.memoryedit1.UseMnemonic = false;
            this.memoryedit1.UseVisualStyleBackColor = true;
            this.memoryedit1.Click += new System.EventHandler(this.memoryedit1_Click);
            // 
            // iglink
            // 
            this.iglink.AutoSize = true;
            this.iglink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.iglink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iglink.Location = new System.Drawing.Point(231, 239);
            this.iglink.Name = "iglink";
            this.iglink.Size = new System.Drawing.Size(89, 13);
            this.iglink.TabIndex = 16;
            this.iglink.TabStop = true;
            this.iglink.Text = "Infamous Gamerz";
            this.iglink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // hMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 253);
            this.Controls.Add(this.iglink);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hProcess_Group);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hMainWindow";
            this.Text = "Infamous Gamerz Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hMainWindow_FormClosing);
            this.hProcess_Group.ResumeLayout(false);
            this.hProcess_Group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.GroupBox hProcess_Group;
		private System.Windows.Forms.TextBox hProcess_Status;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer hSearchForProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel iglink;
        private System.Windows.Forms.Button memoryedit3;
        private System.Windows.Forms.Button memoryedit2;
        private System.Windows.Forms.Button memoryedit1;
        private System.Windows.Forms.Button memadjustable1freeze;
        private System.Windows.Forms.TextBox memadjustable1;
	}
}

