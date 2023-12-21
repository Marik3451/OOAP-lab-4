using System.Collections.Generic;

namespace OOAP_lab_4
{
    abstract class Employee
    {
        protected IPaymentSystem paymentSystem;
        protected string name;
        protected string position;

        public Employee(string name, string position, IPaymentSystem paymentSystem)
        {
            this.name = name;
            this.position = position;
            this.paymentSystem = paymentSystem;
        }

        public abstract void PaySalary();
        public override string ToString()
        {
            return $"Ім'я: {name}, Посада в компанії: {position}";
        }
    }
}