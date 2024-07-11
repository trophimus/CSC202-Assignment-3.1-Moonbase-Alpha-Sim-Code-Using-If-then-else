namespace CSC202_Moonbase_Alpha_Simulation
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNexit = new System.Windows.Forms.Button();
            this.BTNabout = new System.Windows.Forms.Button();
            this.BTNcontrol = new System.Windows.Forms.Button();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNnorth = new System.Windows.Forms.Button();
            this.GBNavDevice = new System.Windows.Forms.GroupBox();
            this.BTNsouth = new System.Windows.Forms.Button();
            this.BTNeast = new System.Windows.Forms.Button();
            this.BTNwest = new System.Windows.Forms.Button();
            this.textBoxExplain = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GBNavDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.BTNexit);
            this.groupBox1.Controls.Add(this.BTNabout);
            this.groupBox1.Controls.Add(this.BTNcontrol);
            this.groupBox1.Controls.Add(this.textBoxRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(58, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // BTNexit
            // 
            this.BTNexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNexit.ForeColor = System.Drawing.Color.Red;
            this.BTNexit.Location = new System.Drawing.Point(146, 110);
            this.BTNexit.Name = "BTNexit";
            this.BTNexit.Size = new System.Drawing.Size(75, 33);
            this.BTNexit.TabIndex = 4;
            this.BTNexit.Text = "Exit";
            this.BTNexit.UseVisualStyleBackColor = false;
            this.BTNexit.Click += new System.EventHandler(this.BTNexit_Click);
            // 
            // BTNabout
            // 
            this.BTNabout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNabout.ForeColor = System.Drawing.Color.Purple;
            this.BTNabout.Location = new System.Drawing.Point(15, 110);
            this.BTNabout.Name = "BTNabout";
            this.BTNabout.Size = new System.Drawing.Size(69, 33);
            this.BTNabout.TabIndex = 3;
            this.BTNabout.Text = "About";
            this.BTNabout.UseVisualStyleBackColor = false;
            this.BTNabout.Click += new System.EventHandler(this.BTNabout_Click);
            // 
            // BTNcontrol
            // 
            this.BTNcontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNcontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNcontrol.Location = new System.Drawing.Point(136, 56);
            this.BTNcontrol.Name = "BTNcontrol";
            this.BTNcontrol.Size = new System.Drawing.Size(75, 23);
            this.BTNcontrol.TabIndex = 2;
            this.BTNcontrol.Text = "Details";
            this.BTNcontrol.UseVisualStyleBackColor = false;
            this.BTNcontrol.Click += new System.EventHandler(this.BTNcontrol_Click);
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(15, 56);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.ReadOnly = true;
            this.textBoxRoom.Size = new System.Drawing.Size(89, 20);
            this.textBoxRoom.TabIndex = 1;
            this.textBoxRoom.Text = "text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Room";
            // 
            // BTNnorth
            // 
            this.BTNnorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNnorth.Location = new System.Drawing.Point(65, 25);
            this.BTNnorth.Name = "BTNnorth";
            this.BTNnorth.Size = new System.Drawing.Size(58, 23);
            this.BTNnorth.TabIndex = 1;
            this.BTNnorth.Text = "North";
            this.BTNnorth.UseVisualStyleBackColor = true;
            this.BTNnorth.Click += new System.EventHandler(this.BTNnorth_Click);
            // 
            // GBNavDevice
            // 
            this.GBNavDevice.BackColor = System.Drawing.Color.Navy;
            this.GBNavDevice.Controls.Add(this.BTNsouth);
            this.GBNavDevice.Controls.Add(this.BTNeast);
            this.GBNavDevice.Controls.Add(this.BTNwest);
            this.GBNavDevice.Controls.Add(this.BTNnorth);
            this.GBNavDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNavDevice.ForeColor = System.Drawing.Color.Red;
            this.GBNavDevice.Location = new System.Drawing.Point(58, 189);
            this.GBNavDevice.Name = "GBNavDevice";
            this.GBNavDevice.Size = new System.Drawing.Size(198, 169);
            this.GBNavDevice.TabIndex = 2;
            this.GBNavDevice.TabStop = false;
            this.GBNavDevice.Text = "Personal Nav Device";
            // 
            // BTNsouth
            // 
            this.BTNsouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsouth.Location = new System.Drawing.Point(65, 118);
            this.BTNsouth.Name = "BTNsouth";
            this.BTNsouth.Size = new System.Drawing.Size(58, 23);
            this.BTNsouth.TabIndex = 4;
            this.BTNsouth.Text = "South";
            this.BTNsouth.UseVisualStyleBackColor = true;
            this.BTNsouth.Click += new System.EventHandler(this.BTNsouth_Click);
            // 
            // BTNeast
            // 
            this.BTNeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeast.Location = new System.Drawing.Point(136, 78);
            this.BTNeast.Name = "BTNeast";
            this.BTNeast.Size = new System.Drawing.Size(49, 23);
            this.BTNeast.TabIndex = 3;
            this.BTNeast.Text = "East";
            this.BTNeast.UseVisualStyleBackColor = true;
            this.BTNeast.Click += new System.EventHandler(this.BTNeast_Click);
            // 
            // BTNwest
            // 
            this.BTNwest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNwest.Location = new System.Drawing.Point(15, 78);
            this.BTNwest.Name = "BTNwest";
            this.BTNwest.Size = new System.Drawing.Size(49, 23);
            this.BTNwest.TabIndex = 2;
            this.BTNwest.Text = "West";
            this.BTNwest.UseVisualStyleBackColor = true;
            this.BTNwest.Click += new System.EventHandler(this.BTNwest_Click);
            // 
            // textBoxExplain
            // 
            this.textBoxExplain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExplain.Location = new System.Drawing.Point(1024, 78);
            this.textBoxExplain.Multiline = true;
            this.textBoxExplain.Name = "textBoxExplain";
            this.textBoxExplain.Size = new System.Drawing.Size(173, 139);
            this.textBoxExplain.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC202_Moonbase_Alpha_Simulation.Properties.Resources.Future_Lunar_Command_Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.textBoxExplain);
            this.Controls.Add(this.GBNavDevice);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Lunar Command Center";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBNavDevice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Button BTNcontrol;
        private System.Windows.Forms.Button BTNabout;
        private System.Windows.Forms.Button BTNexit;
        private System.Windows.Forms.Button BTNnorth;
        private System.Windows.Forms.GroupBox GBNavDevice;
        private System.Windows.Forms.Button BTNeast;
        private System.Windows.Forms.Button BTNwest;
        private System.Windows.Forms.Button BTNsouth;
        private System.Windows.Forms.TextBox textBoxExplain;
    }
}

