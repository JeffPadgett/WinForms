namespace Farmer
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cows = new System.Windows.Forms.Label();
            this.numericInput = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cows
            // 
            this.Cows.AutoSize = true;
            this.Cows.Location = new System.Drawing.Point(73, 48);
            this.Cows.Name = "Cows";
            this.Cows.Size = new System.Drawing.Size(41, 17);
            this.Cows.TabIndex = 1;
            this.Cows.Text = "Cows";
            // 
            // numericInput
            // 
            this.numericInput.Location = new System.Drawing.Point(136, 48);
            this.numericInput.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericInput.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericInput.Name = "numericInput";
            this.numericInput.Size = new System.Drawing.Size(120, 22);
            this.numericInput.TabIndex = 2;
            this.numericInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericInput.ValueChanged += new System.EventHandler(this.numericInput_ValueChanged);
            // 
            // button2
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericInput);
            this.Controls.Add(this.Cows);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Cows;
        private System.Windows.Forms.NumericUpDown numericInput;
        private System.Windows.Forms.Button button2;
    }
}

