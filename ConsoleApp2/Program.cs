using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("------------IMENIK-----------");
            Console.WriteLine("-----------------------------");
            
            List<string> Imena = new List<string>();
            List<string> BrojTel = new List<string>();
            while (true)
            {
                Console.WriteLine("Meni:");
                Console.WriteLine("1. Dodajte novi kontakt, 2. Izlistaj sve kontakte, 3.Pretraga imenika, 4.Izbrisi, 5. Napusti aplikaciju");
                string unos = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("");
                switch (unos)
                {
                    case "1":
                          Console.WriteLine("Ime i prezime: ");
                        String ime = "";
                        while (true)
                        {
                            ime = Console.ReadLine();
                            if (ime.Length <=4)
                                Console.WriteLine("Potrebno je ponovo uneti ime i prezime!");
                            else
                                break;
                        }
                        Imena.Add(ime);
                        String brojTele = "";
                          Console.WriteLine("Broj telefona");
                        while (true)
                        {
                            brojTele = Console.ReadLine();
                            if (brojTele.Length <=4)
                                Console.WriteLine("Potrebno je ponovo uneti broj telefona!");
                            else
                                break;
                        }
                        BrojTel.Add(brojTele);
                        break;
                    case "2":
                        if (Imena.Count == 0)
                            Console.WriteLine("Imenik je prazan!");
                        else
                        {
                            Console.WriteLine("Ime Prezime --------- Broj telefona");
                            for (int index = 0; index < Imena.Count; index++)
                                Console.WriteLine($"{index + 1}. {Imena[index]} --------- {BrojTel[index]}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Unesite ime ili prezime za pretragu: ");
                        String pretraga = Console.ReadLine().ToUpper();
                        Console.WriteLine("Ime Prezime --------- Broj telefona");
                        for (int index = 0; index < Imena.Count; index++)
                            if (Imena[index].ToUpper().Contains(pretraga))
                                Console.WriteLine($"{index + 1}. {Imena[index]} --------- {BrojTel[index]}");
                        break;
                    case "4":
                        /*TODO Brisanje napraviti tako sto se unese ime a 
                         ne indeks. Obratiti paznju na to da opet
                        morate da nadjete indeks sami jer morate da
                        obrisete broj iz druge liste :)*/
                        Console.WriteLine("Unesite ime ili prezime za brisanje: ");
                        pretraga = "";
                        while (true)
                        {
                            pretraga = Console.ReadLine().ToUpper();
                            if (pretraga.Length <= 4)
                                Console.WriteLine("Potrebno je ponovo uneti ime ili prezime za brisanje");
                            else
                            {
                                int brojac = 0;
                                int ind=0;
                                for (int index = 0; index < Imena.Count; index++)
                                    if (Imena[index].ToUpper().Contains(pretraga)) {
                                        brojac++;
                                        ind = index;
                                    }
                                if (brojac == 0)
                                    Console.WriteLine("Ne postoji u imeniku takvo ime!");
                                else if (brojac > 1)
                                    Console.WriteLine("U imeniku nalazi se vise osoba sa tim imenom ili prezimenom!");
                                else
                                {
                                    Imena.RemoveAt(ind);
                                    BrojTel.RemoveAt(ind);
                                    Console.WriteLine("Uspesno ste obrisali kontakt iz imenika!");
                                    break;
                                }
                                Console.WriteLine("Potrebno je ponovo uneti ime ili prezime za brisanje");
                            }

                                
                        }
                        
                             



                        break;
                    case "5":
                        break;

                }
                if (unos == "5")
                    break;

            }

        }
    }
}
