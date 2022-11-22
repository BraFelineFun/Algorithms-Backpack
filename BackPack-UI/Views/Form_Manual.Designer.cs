namespace BackPack_UI
{
    partial class Form_Manual
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.H1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.createBackpack_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_itemCountDesc = new System.Windows.Forms.Label();
            this.label_itemCount = new System.Windows.Forms.Label();
            this.button_solution = new System.Windows.Forms.Button();
            this.textBox_backpackCapacity = new System.Windows.Forms.TextBox();
            this.label_backpackCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_import = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.FLP_answer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H1.Location = new System.Drawing.Point(195, -10);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(447, 65);
            this.H1.TabIndex = 0;
            this.H1.Text = "Задача о рюкзаке";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkSalmon;
            this.button_add.Location = new System.Drawing.Point(12, 102);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(151, 38);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить вещь";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // createBackpack_button
            // 
            this.createBackpack_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.createBackpack_button.Location = new System.Drawing.Point(436, 102);
            this.createBackpack_button.Name = "createBackpack_button";
            this.createBackpack_button.Size = new System.Drawing.Size(151, 38);
            this.createBackpack_button.TabIndex = 2;
            this.createBackpack_button.Text = "Создать рюкзак";
            this.createBackpack_button.UseVisualStyleBackColor = false;
            this.createBackpack_button.Click += new System.EventHandler(this.createBackpack_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SandyBrown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 172);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 157);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Tag = "FWP_things";
            // 
            // label_itemCountDesc
            // 
            this.label_itemCountDesc.AutoSize = true;
            this.label_itemCountDesc.Location = new System.Drawing.Point(12, 153);
            this.label_itemCountDesc.Name = "label_itemCountDesc";
            this.label_itemCountDesc.Size = new System.Drawing.Size(117, 15);
            this.label_itemCountDesc.TabIndex = 4;
            this.label_itemCountDesc.Text = "Количество вещей: ";
            // 
            // label_itemCount
            // 
            this.label_itemCount.AutoSize = true;
            this.label_itemCount.Location = new System.Drawing.Point(150, 154);
            this.label_itemCount.Name = "label_itemCount";
            this.label_itemCount.Size = new System.Drawing.Size(13, 15);
            this.label_itemCount.TabIndex = 5;
            this.label_itemCount.Text = "0";
            // 
            // button_solution
            // 
            this.button_solution.BackColor = System.Drawing.Color.OrangeRed;
            this.button_solution.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_solution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_solution.Location = new System.Drawing.Point(276, 360);
            this.button_solution.Margin = new System.Windows.Forms.Padding(4);
            this.button_solution.Name = "button_solution";
            this.button_solution.Size = new System.Drawing.Size(281, 38);
            this.button_solution.TabIndex = 6;
            this.button_solution.Text = "Найти решение";
            this.button_solution.UseVisualStyleBackColor = false;
            this.button_solution.Click += new System.EventHandler(this.button_solution_Click);
            // 
            // textBox_backpackCapacity
            // 
            this.textBox_backpackCapacity.Location = new System.Drawing.Point(436, 171);
            this.textBox_backpackCapacity.Name = "textBox_backpackCapacity";
            this.textBox_backpackCapacity.Size = new System.Drawing.Size(151, 23);
            this.textBox_backpackCapacity.TabIndex = 7;
            // 
            // label_backpackCapacity
            // 
            this.label_backpackCapacity.AutoSize = true;
            this.label_backpackCapacity.Location = new System.Drawing.Point(436, 153);
            this.label_backpackCapacity.Name = "label_backpackCapacity";
            this.label_backpackCapacity.Size = new System.Drawing.Size(135, 15);
            this.label_backpackCapacity.TabIndex = 8;
            this.label_backpackCapacity.Text = "Вместимость рюкзака: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "МНОГО МНОГО МНОГО ТЕКСТА";
            // 
            // button_import
            // 
            this.button_import.BackColor = System.Drawing.Color.Orange;
            this.button_import.Location = new System.Drawing.Point(650, 102);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(150, 38);
            this.button_import.TabIndex = 9;
            this.button_import.Text = "Импортировать значения";
            this.button_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_import.UseVisualStyleBackColor = false;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_answer.Location = new System.Drawing.Point(42, 413);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(95, 25);
            this.label_answer.TabIndex = 10;
            this.label_answer.Text = "Решение:";
            // 
            // FLP_answer
            // 
            this.FLP_answer.AutoScroll = true;
            this.FLP_answer.Location = new System.Drawing.Point(42, 455);
            this.FLP_answer.Name = "FLP_answer";
            this.FLP_answer.Size = new System.Drawing.Size(736, 198);
            this.FLP_answer.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.FLP_answer);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.label_backpackCapacity);
            this.Controls.Add(this.textBox_backpackCapacity);
            this.Controls.Add(this.button_solution);
            this.Controls.Add(this.label_itemCount);
            this.Controls.Add(this.label_itemCountDesc);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.createBackpack_button);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.H1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label H1;
        private Button button_add;
        private Button createBackpack_button;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label_itemCountDesc;
        private Label label_itemCount;
        private Button button_solution;
        private TextBox textBox_backpackCapacity;
        private Label label_backpackCapacity;
        private Button button_import;
        private Label label_answer;
        private FlowLayoutPanel FLP_answer;
    }
}