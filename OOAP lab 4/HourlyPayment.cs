using System.Windows.Forms;

namespace OOAP_lab_4
{
    class HourlyPayment : IPaymentSystem
    {
        public void ProcessPayment()
        {
            MessageBox.Show("Зарплата за годинами обчислена.");
        }
    }
}