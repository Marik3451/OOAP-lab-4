using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOAP_lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            List<Employee> employees = new List<Employee>
            {
                new RegularEmployee("Іван", "Програміст", new HourlyPayment()),
                new RegularEmployee("Марія", "Дизайнер", new ContractPayment()),
                new RegularEmployee("Петро", "Бухгалтер", new HourlyPayment()),
                new RegularEmployee("Настя", "Лід", new ContractPayment()),
                new RegularEmployee("Зоряна", "Бек-енд", new HourlyPayment())
            };

            foreach (Employee employee in employees)
            {
                listBox1.Items.Add(employee);
            }
        }

        private void ListBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримати вибраного працівника та викликати метод PaySalary
            if (listBox1.SelectedItem is Employee selectedEmployee)
            {
                selectedEmployee.PaySalary();
            }
        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }
    }
}
