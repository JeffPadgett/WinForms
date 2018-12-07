namespace PartyPlanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.Decorations = new System.Windows.Forms.CheckBox();
            this.Healthy = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Cost = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Decorations
            // 
            this.Decorations.AutoSize = true;
            this.Decorations.Checked = true;
            this.Decorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Decorations.Location = new System.Drawing.Point(93, 114);
            this.Decorations.Name = "Decorations";
            this.Decorations.Size = new System.Drawing.Size(148, 21);
            this.Decorations.TabIndex = 1;
            this.Decorations.Text = "Fancy Decorations";
            this.Decorations.UseVisualStyleBackColor = true;
            this.Decorations.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Healthy
            // 
            this.Healthy.AutoSize = true;
            this.Healthy.Location = new System.Drawing.Point(93, 154);
            this.Healthy.Name = "Healthy";
            this.Healthy.Size = new System.Drawing.Size(124, 21);
            this.Healthy.TabIndex = 2;
            this.Healthy.Text = "Healthy Option";
            this.Healthy.UseVisualStyleBackColor = true;
            this.Healthy.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 58);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.BackColor = System.Drawing.SystemColors.Control;
            this.Cost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cost.Location = new System.Drawing.Point(50, 224);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(36, 17);
            this.Cost.TabIndex = 4;
            this.Cost.Text = "Cost";
            this.Cost.Click += new System.EventHandler(this.label2_Click);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(108, 221);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(90, 20);
            this.costLabel.TabIndex = 5;
            this.costLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Healthy);
            this.Controls.Add(this.Decorations);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Decorations;
        private System.Windows.Forms.CheckBox Healthy;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label costLabel;
    }
}

