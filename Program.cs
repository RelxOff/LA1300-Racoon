using System;

namespace Workshop_Racoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            string choice2 = "";
            int num = -1;
            int num2 = 0;
            
            string[] Workshopname = new string[20];
            string[] Workshop1 = new string[20];
            string[] Workshop2 = new string[20];
            string[] Workshop3 = new string[20];


            while (true)
            {
                Console.WriteLine("Wollen Sie sich für einen Workshop eintragen?[ja/nein]");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "ja":
                        Console.Clear();
                        num++;
                        num2++;
                        
                        string[] myWorkshop = Workshop();
                       

                        Workshopname[num] = myWorkshop[0];
                        Workshop1[num] = myWorkshop[1];
                        Workshop2[num] = myWorkshop[2];
                        Workshop3[num] = myWorkshop[3];

                        Console.Clear();
                        break;

                    case "nein":
                        while (true)
                        {
                            Console.WriteLine("Wollen Sie die Kursanmeldungen sehen? [ja/nein]");
                            choice2 = Console.ReadLine();
                            if (choice2== "ja" || choice2 == "nein")
                            {
                                break;
                            }
                        }

                        switch (choice2)
                        {
                            case "ja":
                            Console.Clear();
                                Console.WriteLine("Geben Sie irgendeine Taste ein, um fortzufahren\n");
                            
                                for (int i = 0; i <num2 ; i++)
                                {
                                    Console.WriteLine(Workshopname[i] +"@students.ksba.ch   " + Workshop1[i] +"  "+ Workshop2[i]+"  "+Workshop3[i]);
                                   

                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case "nein":
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("Eingabe wurde nicht erkannt");
                                break;

                        }

                       break;
                    default:
                        Console.WriteLine("Eingabe wurde nicht erkannt");
                        break;
                }
                
                    
            }

            
            
            
            
            
            static string[] Workshop()
            {
                string[] Workshop = new string[10];
                int fussballnum1 = 0;
                int basketballnum1 = 0;
                int zeichnennum1 = 0;
                int volleyballnum1 = 0;
                int programmnum1 = 0;
                int musiknum1 = 0;
                int geschichtenum1 = 0;
                int baselnnum1 = 0;
                int nothilfenum1 = 0;
                int kochennum1 = 0;
                int fussballnum2 = 0;
                int basketballnum2 = 0;
                int zeichnennum2 = 0;
                int volleyballnum2 = 0;
                int programmnum2 = 0;
                int musiknum2 = 0;
                int geschichtenum2 = 0;
                int baselnnum2 = 0;
                int nothilfenum2 = 0;
                int kochennum2 = 0;
                int fussballnum3 = 0;
                int basketballnum3 = 0;
                int zeichnennum3 = 0;
                int volleyballnum3 = 0;
                int programmnum3 = 0;
                int musiknum3 = 0;
                int geschichtenum3 = 0;
                int baselnnum3 = 0;
                int nothilfenum3 = 0;
                int kochennum3 = 0;



                Console.WriteLine("Geben Sie ihren Vornamen und Nachnamen ein");
               
                
                    Workshop[0] = Console.ReadLine();

                    Console.WriteLine("Diese Workshops stehen zur Auswahl:");
                    Console.WriteLine();
                    Console.WriteLine("Fussball\nBasketball\nZeichnen\nVolleyball\nProgrammieren\nMusik\nGeschichte\nBastel\nNothilfe\nKochen");
                    Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("Geben Sie ihre erste Wahl ein");
                    Workshop[1] = Console.ReadLine();
                switch (Workshop[1])
                { 
                    case "Fussball" :
                        fussballnum1++;
                        break;
                    case "Basketball":
                        basketballnum1++;
                        break;
                    case "Zeichnen":
                        zeichnennum1++;
                        break;
                    case "Volleyball":
                        volleyballnum1++;
                        break;
                    case "Programmieren":
                        programmnum1++;
                        break;
                    case "Musik":
                        musiknum1++;
                        break;
                    case "Geschichte":
                        geschichtenum1++;
                        break;
                    case "Bastel":
                        baselnnum1++;
                        break;
                    case "Nothilfe":
                        nothilfenum1++;
                        break;
                    case "Kochen":
                        kochennum1++;
                        break;
                    default:
                        Console.WriteLine("Bitte geben Sie etwas aus der Liste ein");
                        break;
                }
                    if (fussballnum1>20||basketballnum1>20||zeichnennum1>20||volleyballnum1>20||programmnum1>20||musiknum1>20||geschichtenum1>20||nothilfenum1>20||kochennum1>20)
                    {
                        Console.WriteLine("Dieser Kurs ist leider schon voll, bitte tragen Sie sich für einen anderen Kurs ein.");
                    }
                    if (Workshop[1] == "Bastel" ||Workshop[1]== "Fussball"||Workshop[1] == "Basketball"||Workshop[1]=="Zeichnen"||Workshop[1]=="Volleyball"||Workshop[1]=="Programmieren"||Workshop[1]=="Musik"||Workshop[1]== "Geschichte"||Workshop[1] == "Nothilfe"||Workshop[1]=="Kochen")
                    {
                        break; 
                    }
                }



                while (true)
                {
                    Console.WriteLine("Geben Sie ihre zweite Wahl ein");
                    Workshop[2] = Console.ReadLine();
                    switch (Workshop[2])
                    {
                        case "Fussball":
                            fussballnum2++;
                            break;
                        case "Basketball":
                            basketballnum2++;
                            break;
                        case "Zeichnen":
                            zeichnennum2++;
                            break;
                        case "Volleayball":
                            volleyballnum2++;
                            break;
                        case "Programmieren":
                            programmnum2++;
                            break;
                        case "Musik":
                            musiknum2++;
                            break;
                        case "Geschichte":
                            geschichtenum2++;
                            break;
                        case "Bastel":
                            baselnnum2++;
                            break;
                        case "Nothilfe":
                            nothilfenum2++;
                            break;
                        case "Kochen":
                            kochennum2++;
                            break;
                        default:
                            Console.WriteLine("Bitte geben Sie etwas aus der Liste ein");
                            break;
                    }
                    if (fussballnum2 > 20 || basketballnum2 > 20 || zeichnennum2 > 20 || volleyballnum2 > 20 || programmnum2 > 20 || musiknum2 > 20 || geschichtenum2 > 20 || nothilfenum2 > 20 || kochennum2 > 20)
                    {
                        Console.WriteLine("Dieser Kurs ist leider schon voll, bitte tragen Sie sich für einen anderen Kurs ein.");
                    }
                    if (Workshop[2] == "Bastel"||Workshop[2] == "Fussball" || Workshop[2] == "Basketball" || Workshop[2] == "Zeichnen" || Workshop[2] == "Volleyball" || Workshop[2] == "Programmieren" || Workshop[2] == "Musik" || Workshop[2] == "Geschichte" || Workshop[2] == "Nothilfe" || Workshop[2] == "Kochen")
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Geben Sie ihre dritte Wahl ein");
                    Workshop[3] = Console.ReadLine();
                    switch (Workshop[3])
                    {
                        case "Fussball":
                            fussballnum3++;
                            break;
                        case "Basketball":
                            basketballnum3++;
                            break;
                        case "Zeichnen":
                            zeichnennum3++;
                            break;
                        case "Volleayball":
                            volleyballnum3++;
                            break;
                        case "Programmieren":
                            programmnum3++;
                            break;
                        case "Musik":
                            musiknum3++;
                            break;
                        case "Geschichte":
                            geschichtenum3++;
                            break;
                        case "Bastel":
                            baselnnum3++;
                            break;
                        case "Nothilfe":
                            nothilfenum3++;
                            break;
                        case "Kochen":
                            kochennum3++;
                            break;
                        default:
                            Console.WriteLine("Bitte geben Sie etwas aus der Liste ein");
                            break;
                    }
                    if (fussballnum3 > 20 || basketballnum3 > 20 || zeichnennum3 > 20 || volleyballnum3 > 20 || programmnum3 > 20 || musiknum3 > 20 || geschichtenum3 > 20 || nothilfenum3 > 20 || kochennum3 > 20)
                    {
                        Console.WriteLine("Dieser Kurs ist leider schon voll, bitte tragen Sie sich für einen anderen Kurs ein.");
                    }
                    if (Workshop[3] == "Fussball" ||Workshop[3] == "Bastel"|| Workshop[3] == "Basketball" || Workshop[3] == "Zeichnen" || Workshop[3] == "Volleyball" || Workshop[3] == "Programmieren" || Workshop[3] == "Musik" || Workshop[3] == "Geschichte" || Workshop[3] == "Nothilfe" || Workshop[3] == "Kochen")
                    {
                        break;
                    }
                }
                Console.Clear();


                
                return Workshop;
            }
        }
    }
}