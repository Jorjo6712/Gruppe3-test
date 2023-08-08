using System;
using System.Text;

class Consoleopgave
{
    public static void Main(string[] args)
    {
        string path = @"C:\C# opgave";
        ConsoleKeyInfo key;
        string menu =
        " _______________________________________________\n" +
        "|opgave. 1 Matematik                         Z.S|\n" +
        "|opgave. 2 Loop med summering                0.3|\n" +
        "|opgave. 3 Beregne faktuetet af et tal          |\n" +
        "|opgave. 4 Læs og skriv til en fil              |\n" +
        "|opgave. 5 JSON string editor og syntaks checker|\n" +
        "|opgave. 6 Email checker - med loop, if, regler |\n" +
        "|opgave. 7 Email checker - regulær udstyrk      |\n" +
        "|Tast et tal 1 - 7 eller q for at afslute       |\n" +
        "|_______________________________________________|\n";

        while (true)
        {
            Console.WriteLine(menu);
            key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("indlæs 2 tal i hver sin variabek.\nDet vil sige f.eks. Rasultat = tal1 * tal2 / (tal1 - tal2) + tal2 ");
                        Console.WriteLine("\nIndtast Tal1");
                        string input1 = Console.ReadLine();
                        if (!float.TryParse(input1, out float tal1))
                        {
                            Console.WriteLine("da du ikke skriv et tal bliv du sendt til menuen");
                            break;
                        }

                        Console.WriteLine("\nIndtast Tal2");
                        string input2 = Console.ReadLine();
                        if (!float.TryParse(input2, out float tal2))
                        {
                            Console.WriteLine("da du ikke skriv et tal bliv du sendt til menuen");
                            break;
                        }

                        float Resultat = tal1 * tal2 / (tal1 - tal2) + tal2;
                        Console.WriteLine("Tal1 | Tal2 | Resultat\n" + tal1 + "  |  " + tal2 + "  |  " + Resultat);

                        Console.WriteLine("\nvil tilbage til menuen? (y/n)");
                        key = Console.ReadKey();
                        if (key.KeyChar == 'y')
                        {
                            Console.WriteLine("\n");
                            continue;
                        }
                        else if (key.KeyChar == 'n')
                            return;

                    }
                    break;
                case '2':
                    {
                        Console.WriteLine("\nIndtast Tal1");
                        string input3 = Console.ReadLine();
                        if (!int.TryParse(input3, out int tal3))
                        {
                            Console.WriteLine("da du ikke skriv et tal bliv du sendt til menuen");
                            break;
                        }

                        Console.WriteLine("\nIndtast Tal2");
                        string input4 = Console.ReadLine();
                        if (!int.TryParse(input4, out int tal4))
                        {
                            Console.WriteLine("da du ikke skriv et tal bliv du sendt til menuen");
                            break;
                        }

                        int Resultat = tal3 * tal4;
                        Console.WriteLine("\nTal1 | Tal2 | Sum\n" + tal3 + " | " + tal4 + " | " + Resultat);

                        Console.WriteLine("\nvil tilbage til menuen? (y/n)");
                        key = Console.ReadKey();
                        if (key.KeyChar == 'y')
                        {
                            Console.WriteLine("\n");
                            continue;
                        }
                        else if (key.KeyChar == 'n')
                            return;
                    };
                    break;
                case '3':
                    {
                        Console.WriteLine("\nIndlæs 1 heltal i en variabel (n) der skal indgå i beregning.\nDvs. f.eks 5 = 1 * 2 * 3 * 4 * 5 = 120");
                        Console.WriteLine("\nIndtast et Tal");

                        int tal5 = 0;
                        bool isValid = Int32.TryParse(Console.ReadLine(), out tal5);
                        int resultat = 1;
                        if (!isValid)
                        {
                            Console.WriteLine("da du ikke skriv et tal bliv du sendt til menuen");
                            break;
                        }
                        else
                        {
                            for (int n = 1; n <= tal5; n++)
                            {
                                resultat *= n;
                            }
                            Console.WriteLine("Resultat = " + resultat);
                        }
                        Console.WriteLine("\nvil tilbage til menuen? (y/n)");
                        key = Console.ReadKey();
                        if (key.KeyChar == 'y')
                        {
                            Console.WriteLine("\n");
                            continue;
                        }
                        else if (key.KeyChar == 'n')
                            return;
                    }
                    break;

                case '4':
                    {

                        Console.WriteLine("\nwill du 1.Skrive eller 2.Se teksten? ('1' / '2')");
                        key = Console.ReadKey();
                        if (key.KeyChar == '1')
                        {
                                try
                                {
                                    // finder den der fill
                                    StreamWriter sw = new StreamWriter("C:\\Users\\zbczhhj\\Desktop\\Ny mappe\\Test.txt");
                                    // skriv en linje tekst
                                    Console.WriteLine("\nhvad vil du skrive?\n");
                                    string FileText = Console.ReadLine();
                                    sw.WriteLine(FileText);
                                    sw.WriteLine("lavet af Z.S.");

                                    sw.Close();
                                }                             catch(Exception e)
                        
                                {
                                    Console.WriteLine("Exception: " + e.Message);
                                }
                                    finally
                                {
                                    Console.WriteLine("\nTekst er gemt i filen.");
                                }
                        }
                        else if (key.KeyChar == '2')
                        {
                            String line;
                            try
                            {
                                // Finder den der fill
                                StreamReader sr = new StreamReader("C:\\Users\\zbczhhj\\Desktop\\Ny mappe\\Test.txt");
                                Console.WriteLine("\n");
                                // Læs den første linje
                                line = sr.ReadLine();
                                // Læs rasten af fillen
                                while (line != null)
                                {
                                    // Skriver tekst fra fill til kommando vinduet 
                                    Console.WriteLine(line);
                                    //læs den næste linje
                                    line = sr.ReadLine();
                                }
                                //luk fillen
                                sr.Close();
                                Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Exception: " + e.Message);
                            }

                        }   
                    }
                    break;
                    
                           

                        /*opret en tekst fil på c drevet, skrive en tekst til den og gemme den med fil navn
                         *indlæse filen igen, tilføj noget mere tekst, opdater filen
                         *indlæs filen igen og udskriv teksten
                        case '5':
                        case '6':
                        case '7':
                        case 'q':
                            return;*/





                        /*
                        static void ClearArea(int top, int left, int width, int antal)
                    
                        string spaceLine = "";
                        int spaceWidth = width + left;
                        for (int t = 0; t < spaceWidth; t++)
                        {
                            spaceLine += " ";
                        }
                        int lines = antal + top;
                        for (int lineNr = top; lineNr < lines; lineNr++)
                        {
                            Console.CursorLeft = left;
                            Console.CursorTop = lineNr;
                            Console.Write(spaceLine);
                        }
                        */
                }    
            }
        }
    }

