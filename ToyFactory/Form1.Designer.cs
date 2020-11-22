namespace ToysFactory
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Ballbutton = new System.Windows.Forms.Button();
            this.Carbutton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Colorbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 147);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(986, 301);
            this.mainPanel.TabIndex = 1;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next: ";
            // 
            // Ballbutton
            // 
            this.Ballbutton.Location = new System.Drawing.Point(90, 8);
            this.Ballbutton.Name = "Ballbutton";
            this.Ballbutton.Size = new System.Drawing.Size(75, 23);
            this.Ballbutton.TabIndex = 3;
            this.Ballbutton.Text = "BALL";
            this.Ballbutton.UseVisualStyleBackColor = true;
            this.Ballbutton.Click += new System.EventHandler(this.Ballbutton_Click);
            // 
            // Carbutton
            // 
            this.Carbutton.Location = new System.Drawing.Point(183, 8);
            this.Carbutton.Name = "Carbutton";
            this.Carbutton.Size = new System.Drawing.Size(75, 23);
            this.Carbutton.TabIndex = 4;
            this.Carbutton.Text = "CAR";
            this.Carbutton.UseVisualStyleBackColor = true;
            this.Carbutton.Click += new System.EventHandler(this.Carbutton_Click);
            // 
            // Colorbutton
            // 
            this.Colorbutton.Location = new System.Drawing.Point(280, 8);
            this.Colorbutton.Name = "Colorbutton";
            this.Colorbutton.Size = new System.Drawing.Size(75, 23);
            this.Colorbutton.TabIndex = 5;
            this.Colorbutton.UseVisualStyleBackColor = true;
            this.Colorbutton.Click += new System.EventHandler(this.Colorbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 489);
            this.Controls.Add(this.Colorbutton);
            this.Controls.Add(this.Carbutton);
            this.Controls.Add(this.Ballbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ballbutton;
        private System.Windows.Forms.Button Carbutton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Colorbutton;
    }
}

