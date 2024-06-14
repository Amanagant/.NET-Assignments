using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuProgram
{
    

namespace AccountTransferExample
    {
        // Account class with AccountId and AccountBalance properties
        public class Account
        {
            public int AccountId { get; set; }
            public double AccountBalance { get; set; }

            public Account(int accountId, double initialBalance)
            {
                AccountId = accountId;
                AccountBalance = initialBalance;
            }
        }

        // AccountManager class to manage account transfers
        public class AccountManager
        {
            public Account FromAccount { get; set; }
            public Account ToAccount { get; set; }
            public double AmountToTransfer { get; set; }

            public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
            {
                FromAccount = fromAccount;
                ToAccount = toAccount;
                AmountToTransfer = amountToTransfer;
            }

            public void Transfer()
            {
                if (FromAccount.AccountBalance >= AmountToTransfer)
                {
                    FromAccount.AccountBalance -= AmountToTransfer;
                    ToAccount.AccountBalance += AmountToTransfer;
                    Console.WriteLine($"Transfer of {AmountToTransfer} from Account {FromAccount.AccountId} to Account {ToAccount.AccountId} completed.");
                }
                else
                {
                    Console.WriteLine($"Transfer failed due to insufficient funds in Account {FromAccount.AccountId}.");
                }
            }
        }

        class Program
        {
            static void main(string[] args)
            {
                // Create two account objects
                Account accountA = new Account(1, 50000);
                Account accountB = new Account(2, 30000);

                // Create an AccountManager object to manage the transfer
                AccountManager accountManager = new AccountManager(accountA, accountB, 10000);

                // Display initial account balances
                Console.WriteLine($"Before Transfer - Account {accountA.AccountId} Balance: {accountA.AccountBalance}");
                Console.WriteLine($"Before Transfer - Account {accountB.AccountId} Balance: {accountB.AccountBalance}");

                // Create a new thread to perform the transfer
                Thread transferThread = new Thread(new ThreadStart(accountManager.Transfer));

                // Start the transfer thread
                transferThread.Start();

                // Wait for the transfer thread to complete
                transferThread.Join();

                // Display final account balances
                Console.WriteLine($"After Transfer - Account {accountA.AccountId} Balance: {accountA.AccountBalance}");
                Console.WriteLine($"After Transfer - Account {accountB.AccountId} Balance: {accountB.AccountBalance}");
            }
        }
    }
}

