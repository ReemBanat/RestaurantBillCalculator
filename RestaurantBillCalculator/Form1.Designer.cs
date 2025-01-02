
namespace RestaurantBillCalculator
{
    partial class Form1
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
            comboBoxBeverage = new ComboBox();
            comboBoxAppetizer = new ComboBox();
            comboBoxMainCourse = new ComboBox();
            comboBoxDessert = new ComboBox();
            labelSubtotal = new Label();
            labelTax = new Label();
            labelTotal = new Label();
            buttonClear = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxBeverage
            // 
            comboBoxBeverage.FormattingEnabled = true;
            comboBoxBeverage.Location = new Point(114, 59);
            comboBoxBeverage.Name = "comboBoxBeverage";
            comboBoxBeverage.Size = new Size(151, 28);
            comboBoxBeverage.TabIndex = 0;
            comboBoxBeverage.SelectedIndexChanged += comboBoxBeverage_SelectedIndexChanged_1;
            // 
            // comboBoxAppetizer
            // 
            comboBoxAppetizer.FormattingEnabled = true;
            comboBoxAppetizer.Location = new Point(114, 115);
            comboBoxAppetizer.Name = "comboBoxAppetizer";
            comboBoxAppetizer.Size = new Size(151, 28);
            comboBoxAppetizer.TabIndex = 1;
            // 
            // comboBoxMainCourse
            // 
            comboBoxMainCourse.FormattingEnabled = true;
            comboBoxMainCourse.Location = new Point(114, 164);
            comboBoxMainCourse.Name = "comboBoxMainCourse";
            comboBoxMainCourse.Size = new Size(151, 28);
            comboBoxMainCourse.TabIndex = 2;
            // 
            // comboBoxDessert
            // 
            comboBoxDessert.FormattingEnabled = true;
            comboBoxDessert.Location = new Point(114, 212);
            comboBoxDessert.Name = "comboBoxDessert";
            comboBoxDessert.Size = new Size(151, 28);
            comboBoxDessert.TabIndex = 3;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(205, 509);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(107, 20);
            labelSubtotal.TabIndex = 4;
            labelSubtotal.Text = "Subtotal: $0.00";
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Location = new Point(206, 554);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(72, 20);
            labelTax.TabIndex = 5;
            labelTax.Text = "Tax: $0.00";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(206, 598);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(84, 20);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total: $0.00";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(206, 477);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear Bill";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxBeverage);
            groupBox1.Controls.Add(comboBoxAppetizer);
            groupBox1.Controls.Add(comboBoxMainCourse);
            groupBox1.Controls.Add(comboBoxDessert);
            groupBox1.Location = new Point(118, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 257);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = " Menu item";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 218);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Dessert:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 167);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 6;
            label3.Text = "Main Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 118);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "Appetizer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 62);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "Beverage :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(118, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Waiter informatin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 41);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 0;
            label5.Text = "Tabel number :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 80);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 1;
            label6.Text = "Waiter's name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 27);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 754);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonClear);
            Controls.Add(labelTotal);
            Controls.Add(labelTax);
            Controls.Add(labelSubtotal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            labelSubtotal.Text = "Subtotal: $0.00";
            labelTax.Text = "Tax: $0.00";
            labelTotal.Text = "Total: $0.00";
        }

        #endregion

        private ComboBox comboBoxBeverage;
        private ComboBox comboBoxAppetizer;
        private ComboBox comboBoxMainCourse;
        private ComboBox comboBoxDessert;
        private Label labelSubtotal;
        private Label labelTax;
        private Label labelTotal;
        private Button buttonClear;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
    }
}
