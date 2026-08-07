using System;

class Balance_and_Withdraw_Exception_Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter Balance: ");
            int balance = int.Parse(Console.ReadLine());

            Console.Write("Enter Withdraw Amount: ");
            int withdraw = int.Parse(Console.ReadLine());

            if (balance >= withdraw)
            {
                int remain = balance - withdraw;

                Console.WriteLine("Remaining Balance = " + remain);
            }
            else
            {
                throw new Exception("Insufficient Balance");
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

