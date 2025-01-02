using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class Form1 : Form
    {
        // تعريف القوائم والأسعار
        private Dictionary<string, double> beverages = new Dictionary<string, double>
        {
            { "Soda", 1.95 },
            { "Tea", 1.50 },
            { "Coffee", 1.25 },
            { "Mineral Water", 2.95 },
            { "Juice", 2.50 },
            { "Milk", 1.50 }
        };

        private Dictionary<string, double> appetizers = new Dictionary<string, double>
        {
            { "Buffalo Wings", 5.95 },
            { "Buffalo Fingers", 6.95 },
            { "Potato Skins", 8.95 },
            { "Nachos", 8.95 },
            { "Mushroom Caps", 10.95 },
            { "Shrimp Cocktail", 12.95 },
            { "Chips and Salsa", 6.95 }
        };

        private Dictionary<string, double> mainCourses = new Dictionary<string, double>
        {
            { "Chicken Alfredo", 13.95 },
            { "Chicken Picatta", 13.95 },
            { "Turkey Club", 11.95 },
            { "Lobster Pie", 19.95 },
            { "Prime Rib", 20.95 },
            { "Shrimp Scampi", 18.95 },
            { "Turkey Dinner", 13.95 },
            { "Stuffed Chicken", 14.95 },
            { "Seafood Alfredo", 15.95 }
        };

        private Dictionary<string, double> desserts = new Dictionary<string, double>
        {
            { "Apple Pie", 5.95 },
            { "Sundae", 3.95 },
            { "Carrot Cake", 5.95 },
            { "Mud Pie", 4.95 },
            { "Apple Crisp", 5.95 }
        };

        // متغيرات لحساب الفاتورة
        private double subtotal = 0;
        private const double taxRate = 0.16;

        public Form1()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        // تحميل العناصر في ComboBox
        private void LoadComboBoxes()
        {
            comboBoxBeverage.DataSource = new BindingSource(beverages, null);
            comboBoxBeverage.DisplayMember = "Key";
            comboBoxBeverage.ValueMember = "Value";

            comboBoxAppetizer.DataSource = new BindingSource(appetizers, null);
            comboBoxAppetizer.DisplayMember = "Key";
            comboBoxAppetizer.ValueMember = "Value";

            comboBoxMainCourse.DataSource = new BindingSource(mainCourses, null);
            comboBoxMainCourse.DisplayMember = "Key";
            comboBoxMainCourse.ValueMember = "Value";

            comboBoxDessert.DataSource = new BindingSource(desserts, null);
            comboBoxDessert.DisplayMember = "Key";
            comboBoxDessert.ValueMember = "Value";
        }

        // تحديث الفاتورة عند اختيار عنصر
        private void UpdateBill()
        {
            subtotal = 0;

            if (comboBoxBeverage.SelectedValue != null)
                subtotal += (double)comboBoxBeverage.SelectedValue;

            if (comboBoxAppetizer.SelectedValue != null)
                subtotal += (double)comboBoxAppetizer.SelectedValue;

            if (comboBoxMainCourse.SelectedValue != null)
                subtotal += (double)comboBoxMainCourse.SelectedValue;

            if (comboBoxDessert.SelectedValue != null)
                subtotal += (double)comboBoxDessert.SelectedValue;

            double tax = subtotal * taxRate;
            double total = subtotal + tax;

            labelSubtotal.Text = $"Subtotal: {subtotal:C}";
            labelTax.Text = $"Tax: {tax:C}";
            labelTotal.Text = $"Total: {total:C}";
        }

        // أحداث تغيير الاختيار في ComboBox
        private void comboBoxBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void comboBoxAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void comboBoxMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void comboBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        // زر مسح الفاتورة
        private void buttonClear_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            labelSubtotal.Text = "Subtotal: $0.00";
            labelTax.Text = "Tax: $0.00";
            labelTotal.Text = "Total: $0.00";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBeverage_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}