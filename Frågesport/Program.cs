int poäng = 0; 

Console.WriteLine("Välkommen till Oskar Sjölins fotbolls frågesport, du kommer att få 3 alternativa svar på varje fråga som du svarar 1,X eller 2. Lycka till!!!");


Console.WriteLine("Fråga 1: Vilket lag har vunnit mest UEFA Champions League titlar i historien?");
Console.WriteLine("1) Liverpool  X) Real Madrid   2) Barcelona");
string svar1 = Console.ReadLine();
if (svar1 == "X")
{
    poäng++;
    Console.WriteLine("Helt rätt!");
}
else
{
    Console.WriteLine("FEL!");
}

Console.WriteLine("Fråga 2: Vem av följande spelare har gjort mest mål?");
Console.WriteLine("1) Lionel Messi   X) Neymar JR   2) Robert Lewandowski");
string svar2 = Console.ReadLine();
if (svar2 == "1")
{
    poäng ++;
    Console.WriteLine("Korrekt!");
}
else
{
    Console.WriteLine("Helt fel, du är helt ute och cyklar!");
}

Console.WriteLine("Fråga 3: Vilket av följande lag har röda hemma ställ?");
Console.WriteLine("1) Juventus   X) Manchester City 2) Bayern Munchen");
string svar3 = Console.ReadLine();
if (svar3 == "2")
{
    poäng++;
    Console.WriteLine("Solklart rätt!");
}
else
{
    Console.WriteLine("Fel, att du inte ens kunde detta är pinsamt!");
}

Console.WriteLine($"Du fick {poäng} poäng!");
if (poäng == 0)
{
    Console.WriteLine("Du hade inte ett ända rätt din TÖNT!!!");
}
else if (poäng < 3)
{
    Console.WriteLine("Du fick ändå ett okej resultat eller så gissade du bara och hade tur");
}
else
{
    Console.WriteLine("Grymt jobbat du hade alla rätt!!!");
}

Console.WriteLine("Avsluta spelet genom att klicka på valfri tangent!");
Console.ReadKey();