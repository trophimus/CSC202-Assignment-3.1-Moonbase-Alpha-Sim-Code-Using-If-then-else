namespace CSC202_Moonbase_Alpha_Simulation
{
    partial class DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBox));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelPoint1 = new System.Windows.Forms.Label();
            this.labelPoint2 = new System.Windows.Forms.Label();
            this.BTNclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(262, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DARK SIDE OF THE MOON";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxLocation.Location = new System.Drawing.Point(441, 79);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(217, 120);
            this.textBoxLocation.TabIndex = 1;
            // 
            // labelPoint1
            // 
            this.labelPoint1.AutoSize = true;
            this.labelPoint1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPoint1.Location = new System.Drawing.Point(253, 79);
            this.labelPoint1.Name = "labelPoint1";
            this.labelPoint1.Size = new System.Drawing.Size(79, 13);
            this.labelPoint1.TabIndex = 2;
            this.labelPoint1.Text = "Latitude: -20.4°";
            // 
            // labelPoint2
            // 
            this.labelPoint2.AutoSize = true;
            this.labelPoint2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPoint2.Location = new System.Drawing.Point(253, 103);
            this.labelPoint2.Name = "labelPoint2";
            this.labelPoint2.Size = new System.Drawing.Size(91, 13);
            this.labelPoint2.TabIndex = 3;
            this.labelPoint2.Text = "Longitude: 128.9°";
            // 
            // BTNclose
            // 
            this.BTNclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclose.Location = new System.Drawing.Point(248, 350);
            this.BTNclose.Name = "BTNclose";
            this.BTNclose.Size = new System.Drawing.Size(96, 37);
            this.BTNclose.TabIndex = 4;
            this.BTNclose.Text = "Close";
            this.BTNclose.UseVisualStyleBackColor = false;
            this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC202_Moonbase_Alpha_Simulation.Properties.Resources.Future_Moonbase_Alpha;
            this.ClientSize = new System.Drawing.Size(756, 415);
            this.Controls.Add(this.BTNclose);
            this.Controls.Add(this.labelPoint2);
            this.Controls.Add(this.labelPoint1);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogBox";
            this.Text = "About Lunar Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPoint1;
        public System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelPoint2;
        private System.Windows.Forms.Button BTNclose;
    }
}