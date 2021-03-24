namespace BirthdayParadox
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.textPeople = new System.Windows.Forms.TextBox();
            this.textExperiments = new System.Windows.Forms.TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblExperiments = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.prgsProgress = new System.Windows.Forms.ProgressBar();
            this.richDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeText.Location = new System.Drawing.Point(88, 9);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(679, 37);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome to the Birthday Paradox Simulator";
            this.welcomeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textPeople
            // 
            this.textPeople.Location = new System.Drawing.Point(95, 144);
            this.textPeople.Name = "textPeople";
            this.textPeople.Size = new System.Drawing.Size(130, 20);
            this.textPeople.TabIndex = 1;
            // 
            // textExperiments
            // 
            this.textExperiments.Location = new System.Drawing.Point(253, 144);
            this.textExperiments.Name = "textExperiments";
            this.textExperiments.Size = new System.Drawing.Size(130, 20);
            this.textExperiments.TabIndex = 2;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(92, 128);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(95, 13);
            this.lblPeople.TabIndex = 3;
            this.lblPeople.Text = "Number of People:";
            // 
            // lblExperiments
            // 
            this.lblExperiments.AutoSize = true;
            this.lblExperiments.Location = new System.Drawing.Point(250, 128);
            this.lblExperiments.Name = "lblExperiments";
            this.lblExperiments.Size = new System.Drawing.Size(119, 13);
            this.lblExperiments.TabIndex = 4;
            this.lblExperiments.Text = "Number of Experiments:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(410, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 20);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // prgsProgress
            // 
            this.prgsProgress.Location = new System.Drawing.Point(95, 260);
            this.prgsProgress.Name = "prgsProgress";
            this.prgsProgress.Size = new System.Drawing.Size(672, 23);
            this.prgsProgress.Step = 1;
            this.prgsProgress.TabIndex = 6;
            // 
            // richDisplay
            // 
            this.richDisplay.Location = new System.Drawing.Point(95, 305);
            this.richDisplay.Name = "richDisplay";
            this.richDisplay.ReadOnly = true;
            this.richDisplay.Size = new System.Drawing.Size(288, 153);
            this.richDisplay.TabIndex = 7;
            this.richDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 505);
            this.Controls.Add(this.richDisplay);
            this.Controls.Add(this.prgsProgress);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblExperiments);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.textExperiments);
            this.Controls.Add(this.textPeople);
            this.Controls.Add(this.welcomeText);
            this.MaximumSize = new System.Drawing.Size(899, 544);
            this.MinimumSize = new System.Drawing.Size(899, 544);
            this.Name = "Form1";
            this.Text = "Birthday Paradox Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.TextBox textPeople;
        private System.Windows.Forms.TextBox textExperiments;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblExperiments;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ProgressBar prgsProgress;
        private System.Windows.Forms.RichTextBox richDisplay;
    }
}

