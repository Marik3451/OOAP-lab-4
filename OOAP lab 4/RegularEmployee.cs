using System.Windows.Forms;

namespace OOAP_lab_4
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string name, string position, IPaymentSystem paymentSystem)
            : base(name, position, paymentSystem)
        {
        }

        public override void PaySalary()
        {
            MessageBox.Show($"Видано зарплату для {name} ,посада {position}");
            paymentSystem.ProcessPayment();
        }
    }
}