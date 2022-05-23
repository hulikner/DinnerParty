using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerParty
{
    class Program
    {
   
        
        static void Main() 
        {
            List<Guest> allGuests = GetAllGuests();
            
        
            // Console.WriteLine(allGuests);
               makeTable(allGuests);

            TableList makeTable(List<Guest> allGuests)
            {
            
                Table table1 = new Table();
                Table table2 = new Table();
            
                    foreach (Guest guest in allGuests)
                    {
                        bool isTrue = table1.guests.Exists(t => t.Occupation == guest.Occupation);
                            if (isTrue)
                            {
                                table2.guests.Add(guest);
                            }
                            else
                            {
                                table1.guests.Add(guest);
                            }
                    }
                        Console.WriteLine("table 1");
                        foreach (Guest guest in table1.guests) 
                        {
                            Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                        }
                        Console.WriteLine("table 2");
                        foreach (Guest guest in table2.guests) 
                        {
                            Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                        }
                        return new TableList {firstTable = table1.guests, secondTable=table2.guests};
            }
        List<Guest> GetAllGuests()
        {
            List<Guest> guests = new List<Guest> 
            {
            
                new Guest()
                {
                Name= "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
                },
                new Guest()
                {
                Name= "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
                },
                new Guest()
                {
                Name= "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
                },
                new Guest()
                {
                Name= "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
                },
                new Guest()
                {
                Name= "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
                },
                new Guest()
                {
                Name= "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest()
                {
                Name= "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906 – 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
                new Guest()
                {
                Name= "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                },
            };
            return guests;
        }
        }

        public class Guest 
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
        }

        public class Table
        {
            public Table()
            {
                guests = new List<Guest>{};
            }
            public List<Guest> guests {get;set;} = new List<Guest>{};
        }
        public class TableList
        {
            public List<Guest> firstTable {get; set;} = new List<Guest>{};
            public List<Guest> secondTable {get; set;} = new List<Guest>{};
        }

    
    }
}