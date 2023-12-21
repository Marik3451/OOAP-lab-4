using System.Windows.Forms;

namespace OOAP_lab_4
{
    class ContractPayment : IPaymentSystem
    {
        public void ProcessPayment()
        {
            MessageBox.Show("Зарплата за відрядною формою обчислена.");
        }
    }
}