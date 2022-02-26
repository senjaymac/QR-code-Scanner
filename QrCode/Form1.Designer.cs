namespace QrCode
{
    partial class Baseform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baseform));
            this.Instructionslabel = new System.Windows.Forms.Label();
            this.Qrpicbox = new System.Windows.Forms.PictureBox();
            this.Camerabox = new System.Windows.Forms.ComboBox();
            this.Capturebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Qrpicbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instructionslabel
            // 
            resources.ApplyResources(this.Instructionslabel, "Instructionslabel");
            this.Instructionslabel.Name = "Instructionslabel";
            // 
            // Qrpicbox
            // 
            this.Qrpicbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.Qrpicbox, "Qrpicbox");
            this.Qrpicbox.Name = "Qrpicbox";
            this.Qrpicbox.TabStop = false;
            // 
            // Camerabox
            // 
            this.Camerabox.FormattingEnabled = true;
            resources.ApplyResources(this.Camerabox, "Camerabox");
            this.Camerabox.Name = "Camerabox";
            // 
            // Capturebutton
            // 
            this.Capturebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Capturebutton, "Capturebutton");
            this.Capturebutton.Name = "Capturebutton";
            this.Capturebutton.UseVisualStyleBackColor = false;
            this.Capturebutton.Click += new System.EventHandler(this.Capture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Instructionslabel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Exitbutton, "Exitbutton");
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Baseform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Capturebutton);
            this.Controls.Add(this.Camerabox);
            this.Controls.Add(this.Qrpicbox);
            this.MaximizeBox = false;
            this.Name = "Baseform";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Baseform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qrpicbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Instructionslabel;
        private System.Windows.Forms.PictureBox Qrpicbox;
        private System.Windows.Forms.ComboBox Camerabox;
        private System.Windows.Forms.Button Capturebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

