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
            this.button_get_test = new System.Windows.Forms.Button();
            this.textBox_Vmax = new System.Windows.Forms.TextBox();
            this.textBox_Tests = new System.Windows.Forms.TextBox();
            this.label_backpackCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_capacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_getFromFiles = new System.Windows.Forms.Button();
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
            this.FLP_result.Location = new System.Drawing.Point(12, 175);
            this.FLP_result.Margin = new System.Windows.Forms.Padding(20);
            this.FLP_result.MaximumSize = new System.Drawing.Size(776, 399);
            this.FLP_result.MinimumSize = new System.Drawing.Size(776, 399);
            this.FLP_result.Name = "FLP_result";
            this.FLP_result.Size = new System.Drawing.Size(776, 399);
            this.FLP_result.TabIndex = 3;
            // 
            // button_get_test
            // 
            this.button_get_test.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_get_test.Location = new System.Drawing.Point(12, 81);
            this.button_get_test.Name = "button_get_test";
            this.button_get_test.Size = new System.Drawing.Size(151, 38);
            this.button_get_test.TabIndex = 4;
            this.button_get_test.Text = "Сгенерировать тесты";
            this.button_get_test.UseVisualStyleBackColor = false;
            this.button_get_test.Click += new System.EventHandler(this.button_get_test_Click);
            // 
            // textBox_Vmax
            // 
            this.textBox_Vmax.Location = new System.Drawing.Point(186, 90);
            this.textBox_Vmax.Name = "textBox_Vmax";
            this.textBox_Vmax.Size = new System.Drawing.Size(151, 23);
            this.textBox_Vmax.TabIndex = 8;
            // 
            // textBox_Tests
            // 
            this.textBox_Tests.Location = new System.Drawing.Point(367, 90);
            this.textBox_Tests.Name = "textBox_Tests";
            this.textBox_Tests.Size = new System.Drawing.Size(151, 23);
            this.textBox_Tests.TabIndex = 9;
            // 
            // label_backpackCapacity
            // 
            this.label_backpackCapacity.AutoSize = true;
            this.label_backpackCapacity.Location = new System.Drawing.Point(186, 72);
            this.label_backpackCapacity.Name = "label_backpackCapacity";
            this.label_backpackCapacity.Size = new System.Drawing.Size(175, 15);
            this.label_backpackCapacity.TabIndex = 10;
            this.label_backpackCapacity.Text = "Количество предметов (VMax)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество Тестов";
            // 
            // textBox_capacity
            // 
            this.textBox_capacity.Location = new System.Drawing.Point(524, 90);
            this.textBox_capacity.Name = "textBox_capacity";
            this.textBox_capacity.Size = new System.Drawing.Size(151, 23);
            this.textBox_capacity.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вместимость рюкзаков";
            // 
            // button_getFromFiles
            // 
            this.button_getFromFiles.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_getFromFiles.Location = new System.Drawing.Point(12, 125);
            this.button_getFromFiles.Name = "button_getFromFiles";
            this.button_getFromFiles.Size = new System.Drawing.Size(151, 38);
            this.button_getFromFiles.TabIndex = 14;
            this.button_getFromFiles.Text = "Выбрать файлы";
            this.button_getFromFiles.UseVisualStyleBackColor = false;
            this.button_getFromFiles.Click += new System.EventHandler(this.button_getFromFiles_Click);
            // 
            // Autotests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.button_getFromFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_capacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_backpackCapacity);
            this.Controls.Add(this.textBox_Tests);
            this.Controls.Add(this.textBox_Vmax);
            this.Controls.Add(this.button_get_test);
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
        private Button button_get_test;
        private TextBox textBox_Vmax;
        private TextBox textBox_Tests;
        private Label label_backpackCapacity;
        private Label label1;
        private TextBox textBox_capacity;
        private Label label2;
        private Button button_getFromFiles;
    }
}