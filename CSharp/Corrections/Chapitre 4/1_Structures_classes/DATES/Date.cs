using System;
class Date
{
    public int jour = 1;
    public int mois = 1;
    public int annee = 2000;

    public void afficher()
    {
        Console.WriteLine("Date {0}/{1}/{2}", this.jour, this.mois, this.annee);
    }
}