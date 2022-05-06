using Heritage.Entities;

namespace Course
{
    class Heritage
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting - Objeto Account recebendo subclasse BusinessAccount
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 500.0, 0.01);

            // Downcasting - Objeto BusinessAccount sendo atribuído à superclasse Account
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);


            // Convertendo subclasses - SavingsAccount para BusinessAccount
            // if(acc3 is BusinessAccount)
            // {
            //     //BusinessAccount acc5 = (BusinessAccount)acc3;
            //     BusinessAccount acc5 = acc3 as BusinessAccount;
            //     acc5.Loan(200.0);
            //     Console.WriteLine("Loan!");
            // }

            // if(acc3 is SavingsAccount)
            // {
            //     SavingsAccount acc5 = (SavingsAccount)acc3;
            //     acc5.UpdateBalance();
            //     Console.WriteLine("Update!");
            // }

            acc.Withdraw(10.0);
            acc3.Withdraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc3.Balance);
        }
    }
}