namespace ClassesAbstratas.Entities
{
    //Classe selada - não pode ter suclasses
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }


        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Método selado - Não pode ser sobescrito em outra classe
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}