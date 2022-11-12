namespace BackPack_UI
{
    partial class Autotests
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
            this.H1 = new System.Windows.Forms.Label();
            this.FLP_result = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H1.Location = new System.Drawing.Point(172, -6);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(459, 65);
            this.H1.TabIndex = 2;
            this.H1.Text = "Автотестирование";
            // 
            // FLP_result
            // 
            this.FLP_result.AutoScroll = true;
            this.FLP_result.BackColor = System.Drawing.Color.SandyBrown;
            this.FLP_result.Location = new System.Drawing.Point(12, 132);
            this.FLP_result.Margin = new System.Windows.Forms.Padding(20);
            this.FLP_result.MaximumSize = new System.Drawing.Size(776, 442);
            this.FLP_result.MinimumSize = new System.Drawing.Size(776, 442);
            this.FLP_result.Name = "FLP_result";
            this.FLP_result.Size = new System.Drawing.Size(776, 442);
            this.FLP_result.TabIndex = 3;
            // 
            // Autotests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.FLP_result);
            this.Controls.Add(this.H1);
            this.Name = "Autotests";
            this.Text = "Autotests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label H1;
        private FlowLayoutPanel FLP_result;
    }
}