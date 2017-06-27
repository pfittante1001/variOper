using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variOper
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string birthMonth;
            birthMonth = "Oct";
            Console.WriteLine(birthMonth);

            int age = 55;
            Console.WriteLine(55);
            char firstInit = 'f';
            Console.WriteLine(firstInit);
            
            float floatType = 2.164403304897294849383961032f;
            Console.WriteLine(floatType);
            double doubleType = 2.164403304897294849383961032d;
            Console.WriteLine(doubleType);
            decimal decimalType = 2.164403304897294849383961032m;
            Console.WriteLine(decimalType + "\n");

                        int pete = 52;
            int traci = 34;
            Console.WriteLine(pete < traci);

            int pete1 = 52;
            int traci1 = 34;
            Console.WriteLine(pete1 > traci1);

            int pete2 = 52;
            int traci2 = 34;
            Console.WriteLine(pete2 == traci2);

            int numPpl = 4;
            double ttlEach = 13.23;

            double ttlBill = numPpl * ttlEach;
            Console.WriteLine(numPpl * ttlEach + "\n");

            Console.Write("What is the name on the reservation: ");
            String reservName = Console.ReadLine();//Convert string to int

            Console.Write("How many in your party? ");
            int numPpl3 = int.Parse(Console.ReadLine());//Convert string to int

            Console.WriteLine("Reservation Name:" + " " + reservName + "  Number of People: " + numPpl3 + " Total Bill: " + ttlEach * numPpl3);
            Console.WriteLine();

            Console.Write("How many packages of Diapers do you need? ");
            int numPkgs = int.Parse(Console.ReadLine());
            */
            Console.Write("What is the name of the donor? \n");
            string donorName = Console.ReadLine();
            Console.WriteLine("What is the donor address? \n");
            string donorAdd = Console.ReadLine();
            Console.Write("What is the email of the donor? \n");
            string donorEmail = Console.ReadLine();
            Console.Write("What is the fiscal year? \n");
            string fiscalYear = Console.ReadLine();
            Console.Write("How many One dollar bills? \n");
            int dollars = int.Parse(Console.ReadLine());
            Console.Write("How many five dollar bills? \n");
            int fives = int.Parse(Console.ReadLine());
            fives = fives * 5;
            Console.Write("How many Ten dollar bills? \n");
            int tens = int.Parse(Console.ReadLine());
            tens = tens * 10;
            Console.Write("How many twenty dollar bills? \n");
            int twenty = int.Parse(Console.ReadLine());
            twenty = twenty * 20;
            Console.Write("How many fifty dollar bills? \n");
            int fifty = int.Parse(Console.ReadLine());
            fifty = fifty * 50;
            Console.Write("How many hundred dollar bills? \n");
            int hundred = int.Parse(Console.ReadLine());
            hundred = hundred * 100;
            Console.Write("How many quarters? \n");
            int quarters = int.Parse(Console.ReadLine());
            quarters = quarters / 4;
            int donationAmt = (dollars + fives + tens + twenty + fifty + hundred + quarters);
            Console.WriteLine(donationAmt);