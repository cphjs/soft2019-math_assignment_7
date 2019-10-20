using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace assignment_7
{
    class Account
    {
        private double amount;

        public Account(double amount)
        {
            Contract.Requires(amount > 0);
            this.amount = amount;
        }

        public void deposit(double amount)
        {
            Contract.Requires(amount > 0);

            this.amount += amount;
        }

        public void withdraw(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.EnsuresOnThrow<InvalidAmountException>(Contract.OldValue<double>(amount) == amount);
            Contract.Requires<InvalidAmountException>(amount < this.amount);
            this.amount -= amount;
        }

        [ContractInvariantMethod]
        private void invariants()
        {
            Contract.Invariant(this.amount >= 0);
        }
    }
}
