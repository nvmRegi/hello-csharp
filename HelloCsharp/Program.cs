
Console.WriteLine("Buonvenuto in questo nuovo programma!");

string[] mesi = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"};

for(int i = 0; i < mesi.Length; i++)
{
    Console.WriteLine(mesi[i]);
}

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string mesePrefe = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


Console.WriteLine("Il tuo mese preferito è: " + mesePrefe);
Console.WriteLine("Grazie per aver utilizzato questo programma!");
