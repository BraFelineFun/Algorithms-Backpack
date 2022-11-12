namespace BackPack_UI
{
    partial class ChooseAction
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
            this.label_chooseAction = new System.Windows.Forms.Label();
            this.button_manual = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H1.Location = new System.Drawing.Point(184, -6);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(447, 65);
            this.H1.TabIndex = 1;
            this.H1.Text = "Задача о рюкзаке";
            // 
            // label_chooseAction
            // 
            this.label_chooseAction.AutoSize = true;
            this.label_chooseAction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_chooseAction.Location = new System.Drawing.Point(12, 85);
            this.label_chooseAction.Name = "label_chooseAction";
            this.label_chooseAction.Size = new System.Drawing.Size(310, 25);
            this.label_chooseAction.TabIndex = 2;
            this.label_chooseAction.Text = "Выберете способ взаимодействия";
            // 
            // button_manual
            // 
            this.button_manual.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_manual.Location = new System.Drawing.Point(171, 182);
            this.button_manual.Name = "button_manual";
            this.button_manual.Size = new System.Drawing.Size(151, 38);
            this.button_manual.TabIndex = 3;
            this.button_manual.Text = "Вручную";
            this.button_manual.UseVisualStyleBackColor = false;
            this.button_manual.Click += new System.EventHandler(this.button_manual_Click);
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_test.Location = new System.Drawing.Point(466, 182);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(151, 38);
            this.button_test.TabIndex = 4;
            this.button_test.Text = "Автотесты";
            this.button_test.UseVisualStyleBackColor = false;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // ChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_manual);
            this.Controls.Add(this.label_chooseAction);
            this.Controls.Add(this.H1);
            this.MaximumSize = new System.Drawing.Size(816, 354);
            this.MinimumSize = new System.Drawing.Size(816, 354);
            this.Name = "ChooseAction";
            this.Text = "ChooseAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label H1;
        private Label label_chooseAction;
        private Button button_manual;
        private Button button_test;
    }
}