using System;

namespace ATM
{
    public class Program // i make it public in order to access it in UnitTest1 file
    {
        public static  decimal Balance = 0;
         static void Main(string[] args)
          {
                UserInterface();
            }
         public static void UserInterface()
        {
            decimal num = 0;            
            while (true) //  i do not know how many iterations i will have so i use true as condition
            {
                Console.WriteLine("choose transaction:");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. EXIT");
                decimal val=0;
                Decimal.TryParse(Console.ReadLine(), out num);  // parse uer choice to decimal, and store it in num variable 
                if (num < 0)
                {
                    Console.WriteLine("please select number from the list");
                }
                else
                {
                    switch (num)
                    {
                        case 1:
                            {
                                ViewBalance();
                                Console.WriteLine("your balance is " + Balance);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("please enter  amount that you want to deposit");
                                Decimal.TryParse(Console.ReadLine(), out val); // parse uer deposit value to decimal, and store it in val variable 
                                Deposit(val);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("please enter amount that you want to withdraw");
                                Decimal.TryParse(Console.ReadLine(), out val); // parse uer withdraw value, and store it in val variable 
                                withDraw(val);
                                break;
                            }
                        case 4:
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }
        }
        public static decimal ViewBalance()
        {
            return Balance;
        }
        public  static decimal withDraw(decimal value)
        {
            if (value < 0)
            {
                Console.WriteLine("please enter value greater than 0");
                return Balance;
            }
            if (value > Balance)
            {
                Console.WriteLine("your blance is less than your withdraw amount please choose amonut less or equal to your balance amount");
                return Balance;
            }
            else
            {
                Balance-=value;
                return Balance;
            }
        }
        public static decimal Deposit(decimal value)
        {
            if(value < 0)
            {
                Console.WriteLine("please negative values are not allowed, enter value greater than 0");
                return Balance;
            }
            else
            {
                Balance +=value;
                return Balance;
            }
        }
    }
}
