using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_M
{
    class Card_Holder
    {
        String Card_Number;
        int pin;
        string First_Name;
        string Last_Name;
        double Balance;

        public Card_Holder(String Card_Number, int pin, string First_Name, string Last_Name, double Balance)
        {
            this.Card_Number = Card_Number;
            this.pin = pin;
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Balance = Balance;

        }
        public string Get_NUmber()
        {
            return Card_Number;
        }

        public int Get_Pin()
        {
            return pin;
        }
        public string Get_First_Name()
        {
            return First_Name;

        }
        public string Get_last_Name()
        {
            return Last_Name;
        }
        public double Get_Balance()
        {
            return Balance;

        }
        public void Set_Number(String New_Card_Number)
        {
            Card_Number = New_Card_Number;

        }
        public void Set_pin(int New_pin)
        {
            pin = New_pin;
        }

        public void Set_Firsts_Name(string New_First_Name)
        {
            First_Name = New_First_Name;
        }
        public void Set_Last_Name(string New_Last_Name)
        {
            First_Name = New_Last_Name;
        }
        public void Set_Balance(double New_Balance)
        {
            Balance = New_Balance;
        }
        static void Main(string[] args )
        {
            void Print_Option()

            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Show Balance");
                Console.WriteLine("4.Exit");
                Console.WriteLine("------------------------------------");
            }

            void Deposit(Card_Holder currentUser)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("How Much You Want To Deposit ?");
                Console.WriteLine("------------------------------------");
                double deposit = double.Parse(Console.ReadLine());
                currentUser.Set_Balance(deposit+currentUser.Get_Balance());
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Thank You For Your Deposit {deposit} \n Your Account Balance is {currentUser.Get_Balance()}");
                Console.WriteLine("------------------------------------");
            }

            void Withdraw(Card_Holder currentUser)
            {
                Console.WriteLine("How Much You Want To Withdraw ?");
                double withdraw = double.Parse(Console.ReadLine());
                if (currentUser.Get_Balance() < withdraw)
                {   
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("You Don't Have Enough Balance");
                    Console.WriteLine("------------------------------------");
                }
                else
                {
                    currentUser.Set_Balance(currentUser.Get_Balance() - withdraw);
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Thank You For Using yyy ATM");
                    Console.WriteLine("------------------------------------");
                }
            }

            void Balance(Card_Holder currentUser)

            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Current Balance Is {currentUser.Get_Balance()}");
                Console.WriteLine("------------------------------------");
            }


            List<Card_Holder> Card_Holder = new List<Card_Holder>();
            Card_Holder.Add(new Card_Holder("123456789", 1234, "Mohamed", "Alsaffar", 150.5));

            Console.WriteLine("Welcome TO yyy Bank ");
            Console.WriteLine("Please Insert Your Bank Card : ");
            string dCard_Number;
            Card_Holder current_User; 
            dCard_Number = Console.ReadLine();
                    Card_Holder currentUser = Card_Holder.FirstOrDefault(a => a.Card_Number == dCard_Number);
            while (true)
            {
                try
                {
                   
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card Are Not Rejestor");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex + "\n Card Are Not Rejestor");
                    break;
                }
            }
            Console.WriteLine("Please Enter Your Pin : ");
            int user_pin = 0;
            while (true)
            {
                try
                {
                    user_pin = int.Parse(Console.ReadLine());
                        
                    object BB = Card_Holder.FirstOrDefault(a => a.pin == user_pin);
                    if (BB != null)
                    {
                      
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Worng Pin \n Please Try Again ...");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex + "\n Worng Pin");
                    break;
                }
            }
                   
                   Console.WriteLine($"Welcome {currentUser.Get_First_Name() } {currentUser.Get_last_Name()} To Your Account.");         
                   int options =0;
                   do
                   {
                      Print_Option();
                      try{
                            options = int.Parse(Console.ReadLine());
                            if(options ==1){
                                    Deposit(currentUser);
                            }
                            else if(options ==2){
                                Withdraw(currentUser);
                            }
                            else if(options ==3){
                                Balance(currentUser);
                            }
                            else if (options ==4){
                                break;
                            }
                            else{
                                options=0;
                            }

                      }
                      catch{

                      }
                   }
                   while(options !=4);
                   Console.WriteLine("Thank You Have A nice Day");

        }

    }
}
