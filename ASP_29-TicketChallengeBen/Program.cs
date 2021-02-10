using System;

namespace ASP_29_TicketChallengeBen
{
    class Program
    {
        static void Main(string[] args)
        {
            int StuPID; //stands for student personal identification number mr. Wilson and has no other meaning.
            int liSpeed;
            int tiSpeed;
            double fine = 0;
            string clause;
            Console.WriteLine("Please Enter The Students ID Number \"For Identification Purposes Only\"");
            StuPID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Listed Speed");
            liSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Ticketed Speed");
            tiSpeed = int.Parse(Console.ReadLine());
            //Heres where the inovation kicks in!
            Console.WriteLine("Please Enter The Students Class \n(1 - Freshman, 2 - Sohpmore, 3 - Junior, or 4 - Senior)");
            fine = int.Parse(Console.ReadLine());
            clause = Clause(fine);
            fine = DeterminePrice(liSpeed, tiSpeed, fine);
            PrintTicket();

            void PrintTicket() 
            {
                Console.WriteLine("\n\n     Ticket"+"\nStudent ID: "+StuPID+"\nClass: "+clause+"\nSpeed Limit: "+liSpeed
                    +"\nTicket Speed: "+tiSpeed + "\nTotal Fine: $"+fine);
            }
            string Clause(double n)
            {
                string name = "";
                switch (n)
                {
                    case 1: 
                        name = "Freshman";
                        break;
                    case 2:
                        name = "Sohpmore";
                        break;
                    case 3:
                        name = "Junior";
                        break;
                    case 4:
                        name = "Senior";
                        break;
                }
                return name;
            }
            double DeterminePrice(int spe1, int spe2, double fine)
            {
                int spe3 = spe2 - spe1;
                int extraFine = 0;
                int fineDed = 0;
                switch (fine)
                {
                    case 1:
                        if (spe3 >= 20) extraFine = 100;
                        else fineDed = 50;
                        break;
                    case 2:
                        if (spe3 >= 20) extraFine = 100;
                        break;
                    case 3:
                        if (spe3 >= 20) extraFine = 100;
                        break;
                    case 4: 
                        extraFine = 50;
                        if (spe3 > 20) extraFine = 200;
                        break;
                }
                spe3 = (spe3 - (spe3 % 5))/5;
                fine = (spe3*87.5) + 75 + extraFine - fineDed;
                return fine;
            }
            
        }
        
    }
    
}

