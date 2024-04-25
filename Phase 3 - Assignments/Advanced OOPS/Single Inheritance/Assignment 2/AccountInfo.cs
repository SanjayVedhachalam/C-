using System;

namespace Assignment_2
{
    public class AccountInfo : PersonalInfo //Single Inheritance - inheriting the properties of PersonalInfo class
    {
        private static int s_accountNumber = 1000;
        public string AccountNumber { get; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        public AccountInfo(string name, string fatherName, long phone,
        string mail, DateTime dob, string gender,
        string branchName, string ifscCode, double balance) : base(name, fatherName, phone, mail, dob, gender)
        {
            ++s_accountNumber;
            AccountNumber = "ACN" + s_accountNumber;
            BranchName = branchName;
            IFSCCode = ifscCode;
            Balance = balance;
        }

        public void ShowAccountInfo()
        {
            System.Console.WriteLine("-------------------------------------------------------");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Phone Number: {Phone}");
            System.Console.WriteLine($"Mail ID: {Mail}");
            System.Console.WriteLine($"Date of Birth: {DOB}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Account Number: {AccountNumber}");
            System.Console.WriteLine($"Branch Name: {BranchName}");
            System.Console.WriteLine($"IFSC Code: {IFSCCode}");
            System.Console.WriteLine($"Balance: {Balance}");
            System.Console.WriteLine("-------------------------------------------------------");
        }

        public void Deposit()
        {
            System.Console.WriteLine("-------------------------------------------------------");
            System.Console.WriteLine("Deposit");
            System.Console.Write("Enter the amount to be Deposited: ");
            double Amount;
            bool AmountCondition = double.TryParse(Console.ReadLine(), out Amount);
            while (!AmountCondition)
            {
                System.Console.Write("Enter a valid amount: ");
                AmountCondition = double.TryParse(Console.ReadLine(), out Amount);
            }
            Balance += Amount;
            System.Console.Write("Deposit Successful. Do you want to check balance?[yes/no]: ");
            string option = Console.ReadLine().ToLower();
            bool flag = false;
            while (flag.Equals(false))
            {
                if (option.Equals("yes"))
                {
                    ShowBalance();
                    flag = true;
                    System.Console.WriteLine("-------------------------------------------------------");
                    break;
                }
                else if (option.Equals("no"))
                {
                    System.Console.WriteLine("Thank you for using Bank");
                    System.Console.WriteLine("-------------------------------------------------------");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid Option. Try again");
                }
            }
        }

        public void Withdraw()
        {
            System.Console.WriteLine("-------------------------------------------------------");
            System.Console.WriteLine("Withdraw");
            System.Console.Write("Enter the amount to be withdrawn: ");
            double Amount;
            bool AmountCondition = double.TryParse(Console.ReadLine(), out Amount);
            while (!AmountCondition)
            {
                System.Console.Write("Enter a valid amount: ");
                AmountCondition = double.TryParse(Console.ReadLine(), out Amount);
            }
            if (Balance <= 0)
            {
                System.Console.WriteLine("Your Balance is 0. Please deposit amount to withdraw.");
            }
            else
            {
                while (Amount > Balance)
                {
                    System.Console.WriteLine("Insufficient amount. Please try a lesser amount. Your Balance is: {0}", Balance);
                    System.Console.Write("Do you want to proceed? [yes/no]: ");
                    string wish = Console.ReadLine().ToLower();

                    if (wish.Equals("no"))
                    {
                        break;
                    }
                    System.Console.Write("Enter a valid amount: ");
                    AmountCondition = double.TryParse(Console.ReadLine(), out Amount);
                    while (!AmountCondition)
                    {
                        System.Console.Write("Enter a valid amount: ");
                        AmountCondition = double.TryParse(Console.ReadLine(), out Amount);
                    }
                }
                if (Amount <= Balance)
                {
                    Balance -= Amount;
                }
            }
            System.Console.Write("Withdraw ended Successful. Do you want to check balance?[yes/no]: ");
            string option = Console.ReadLine().ToLower();
            bool flag = false;
            while (flag.Equals(false))
            {
                if (option.Equals("yes"))
                {
                    ShowBalance();
                    flag = true;
                    break;
                }
                else if (option.Equals("no"))
                {
                    System.Console.WriteLine("Thank you for using Bank");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid Option. Try again");
                }
            }
        }

        public void ShowBalance()
        {
            System.Console.WriteLine("-------------------------------------------------------");
            System.Console.WriteLine($"Available Balance of {AccountNumber}: {Balance}");
            System.Console.WriteLine("-------------------------------------------------------");
        }
    }
}
