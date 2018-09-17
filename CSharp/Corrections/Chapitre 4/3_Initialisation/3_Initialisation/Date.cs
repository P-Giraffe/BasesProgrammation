using System;
class Date
{
    private int jour;
    private int mois;
    private int annee;

    public Date()
    {
        this.remplir();
    }

    public Date(int j, int m, int a)
    {
        this.annee = a;
        this.mois = Math.Min(Math.Max(1,m), 12);
        int jourMax = this.obtenirJourMax();
        this.jour = Math.Min(Math.Max(1,m), jourMax);
    }

    public void afficher()
    {
        Console.WriteLine("Date : " + this.jour + "/" + this.mois + "/" + this.annee);
    }

    public void remplir()
    {
        String choixUtilisateur = null;
        do
        {
            Console.Write("Souhaitez-vous entrez manuellement les valeurs ? (o/n)");
            choixUtilisateur = Utilisateur.saisirTexte();
            choixUtilisateur = choixUtilisateur.ToLower(); //force les minuscules si besoin
        } while (choixUtilisateur != "o" && choixUtilisateur != "n");
        if (choixUtilisateur == "o")
        {
            do
            {
                Console.Write("Année : ");
                this.annee = Utilisateur.saisirEntier();
            } while (this.annee <= 0);

            do
            {
                Console.Write("Mois : ");
                this.mois = Utilisateur.saisirEntier();
            } while (this.mois < 1 || this.mois > 12);

            int jourMax = this.obtenirJourMax();
            do
            {
                Console.Write("Jour : ");
                this.jour = Utilisateur.saisirEntier();
            } while (this.jour < 1 || this.jour > jourMax);
        }
        else
        {
            DateTime systemDate = DateTime.Now;
            this.jour = systemDate.Day;
            this.mois = systemDate.Month;
            this.annee = systemDate.Year;
        }
    }

    int obtenirJourMax()
    {
        int jourMax = 31;
        if (this.mois == 4
            || this.mois == 6
            || this.mois == 9
            || this.mois == 11)
        {
            jourMax = 30;
        }
        else if (this.mois == 2)
        {
            if (this.estBissextile() == true)
            {
                jourMax = 29;
            }
            else
            {
                jourMax = 28;
            }
        }
        return jourMax;
    }

    bool estBissextile()
    {
        bool estBissextile = false;
        if (this.annee % 4 == 0
            && (this.annee % 100 != 0 || this.annee % 400 == 0))
        {
            estBissextile = true;
        }

        return estBissextile;
    }



    public bool estPlusRecenteQue(Date date2)
    {
        bool estPlusRecente = true;

        if (this.annee < date2.annee)
        {
            estPlusRecente = false;
        }
        else if (this.annee == date2.annee && this.mois < date2.mois)
        {
            estPlusRecente = false;
        }
        else if (this.annee == date2.annee && this.mois == date2.mois && this.jour <= date2.jour)
        {
            estPlusRecente = false;
        }

        return estPlusRecente;
    }

    public int nombreDeJoursVers(Date autreDate)
    {
        int nbJours = 0;

        return nbJours;
    }
}