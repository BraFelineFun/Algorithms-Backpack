namespace BackPack_UI
{
    partial class Form_AddItem
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
            this.button_addThing = new System.Windows.Forms.Button();
            this.label_weight = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H1.Location = new System.Drawing.Point(3, 9);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(434, 50);
            this.H1.TabIndex = 1;
            this.H1.Text = "Добавить новую вещь";
            // 
            // button_addThing
            // 
            this.button_addThing.BackColor = System.Drawing.Color.Coral;
            this.button_addThing.Location = new System.Drawing.Point(24, 342);
            this.button_addThing.Name = "button_addThing";
            this.button_addThing.Size = new System.Drawing.Size(390, 48);
            this.button_addThing.TabIndex = 2;
            this.button_addThing.Text = "Добавить вещь";
            this.button_addThing.UseVisualStyleBackColor = false;
            this.button_addThing.Click += new System.EventHandler(this.button_addThing_Click);
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_weight.Location = new System.Drawing.Point(24, 93);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(120, 25);
            this.label_weight.TabIndex = 3;
            this.label_weight.Text = "Введите вес:";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_weight.Location = new System.Drawing.Point(24, 121);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(313, 29);
            this.textBox_weight.TabIndex = 4;
            this.textBox_weight.TextChanged += new System.EventHandler(this.textBox_weight_TextChanged);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_cost.Location = new System.Drawing.Point(24, 223);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(313, 29);
            this.textBox_cost.TabIndex = 6;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_price.Location = new System.Drawing.Point(24, 195);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(132, 25);
            this.label_price.TabIndex = 5;
            this.label_price.Text = "Введите цену:";
            // 
            // Form_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 402);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.button_addThing);
            this.Controls.Add(this.H1);
            this.Name = "Form_AddItem";
            this.Text = "Form_AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label H1;
        private Button button_addThing;
        private Label label_weight;
        private TextBox textBox_weight;
        private TextBox textBox_cost;
        private Label label_price;
    }
}