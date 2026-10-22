
Console.WriteLine("Podaj nazwe bohatera:");
string bohater = Console.ReadLine()!;

int maxZycie = 100;
int pktZycia;
while (true)
{
    Console.WriteLine("Podaj ilość HP (maks 100):");
    bool poprawnyWynik =  int.TryParse(Console.ReadLine(), out pktZycia);

    if (!poprawnyWynik)
    {
        Console.WriteLine("Wpisz liczbe całkowitą");
        continue;
    }

    if (pktZycia <=0 || pktZycia > maxZycie)
    {
        Console.WriteLine("podaj ilość hp w zakresie 1-100");
        continue;
    }

    break;
}

int złoto;
while (true)
{
    Console.WriteLine("Podaj liczbe złota:");
    bool poprawnyWynik = int.TryParse(Console.ReadLine(), out złoto);
    
    if (!poprawnyWynik)
    {
        Console.WriteLine("Wpisz liczbe całkowitą");
        continue;
    }

    if (złoto < 0)
    {
        Console.WriteLine("Może nie zaczynajmy z długami ;D");
        continue;
    }
    
    if (złoto > 20)
    {
        Console.WriteLine("Za dużo jak na tak małą sakiewkę");
        continue;
    }

    break;

}

int mikstury;
while (true)
{
    Console.WriteLine("Podaj liczbe mikstur:");
    bool poprawnyWynik = int.TryParse(Console.ReadLine(), out mikstury);

    if (!poprawnyWynik)
    {
        Console.WriteLine("Podaj liczbe całkowitą");
        continue;
    }

    if (mikstury < 1 || mikstury > 20)
    {
        Console.WriteLine("Prosze podać liczbę w zakresie 0-20");
        continue;
    }
    
    break;
}

int tura = 1;
bool graDziala = true;


while (graDziala == true && pktZycia > 0)
{
   Console.WriteLine();
   Console.WriteLine("||=====RogalikDDL=====||");
   Console.WriteLine($"Tura:{tura}");
   Console.WriteLine($"Bohatera:{bohater}");
   Console.WriteLine($"Zycie:{pktZycia}/{maxZycie} | Złoto:{złoto} | Mikstury:{mikstury}");
   Console.WriteLine("||=====Menu Akcji======||");
   Console.WriteLine("1.Eksploracja");
   Console.WriteLine("2.Odpoczynek");
   Console.WriteLine("3.Użycie Mikstury");
   Console.WriteLine("4.Zakończ Gre");
   
   string Akcja =  Console.ReadLine()!;

   switch (Akcja)
   {
       case "1":
           złoto = złoto + 10;
           pktZycia = pktZycia - 8;
           Console.WriteLine("Znajdujesz 10 sztuk złota ale tracisz 8 pkt życia ");
           break;
       
       case "2":
           if (złoto >= 3)
           {
               złoto = złoto - 3;
               if (pktZycia <= 95)
                   pktZycia = pktZycia + 5;
               else
               {
                   pktZycia = 100;
               }
               Console.WriteLine("Odpoczywasz w Przytulnym Prystanku odzyskując 5hp, kosztowało cie to 3 złota");
           }
           else
           {
               Console.WriteLine("Za mało złota");
               continue;
           }
           break;
       
       case "3":
           if (pktZycia <= 80)
           {
               pktZycia = pktZycia + 20;
               Console.WriteLine("Mikstura uleczyła 20hp");
           }
           else
               pktZycia = 100;

           break;
       
       case "4":
           Console.WriteLine("Koniec gry");
           graDziala = false;
           break;
       
       default:
           Console.WriteLine("nie ma takiej opcji");
           continue;
   }

   tura++;

   if (pktZycia <= 0)
   {
       Console.WriteLine("Bohater nie może kontynuować");
   }
}
