using System;

public class Application
{
    public void fonctionPrincipale()
    {
        //DEBUT de votre programme

		
		/*
		Console.WriteLine("TRUE : " + estBissextile(2000));
		Console.WriteLine("TRUE : " + estBissextile(2004));
		Console.WriteLine("TRUE : " + estBissextile(2016));
		Console.WriteLine("FALSE : " + estBissextile(2017));
		Console.WriteLine("FALSE : " + estBissextile(200));
		*/

        Console.Write("Prénom : ");
        string prenom = Utilisateur.saisirTexte();
        Console.WriteLine("Nom : ");
        string nom = Utilisateur.saisirTexte();

		if (prenom.StartsWith("P") == true) {
			string pMaj = prenom.ToUpper();
			Console.WriteLine(pMaj);
		}

        Console.WriteLine("Date naissance : ");
        Date dateNaissance = creerDate();

        Date dateEmbauche = null;
        do
        {
            Console.WriteLine("Date embauche : ");
            dateEmbauche = creerDate();
        } while (estPlusRecenteQue(dateNaissance, dateEmbauche) == true);

        Console.WriteLine("Bonjour {0} {1}, voici votre date de naissance ", prenom, nom);
        dateNaissance.afficher();
        Console.WriteLine("et votre date d'embauche");
		dateEmbauche.afficher();

        Utilisateur.saisirTexte();
        //FIN de votre programme
    }

    bool estPlusRecenteQue(Date date1, Date date2)
    {
        bool estPlusRecent = false;

        if (date1.annee > date2.annee)
        {
            estPlusRecent = true;
        }
        else if (date1.annee == date2.annee && date1.mois > date2.mois)
        {
            estPlusRecent = true;
        }
        else if (date1.annee == date2.annee && date1.mois == date2.mois && date1.jour > date2.jour)
        {
            estPlusRecent = true;
        }

        return estPlusRecent;
    }

    //DECLAREZ VOS FONCTIONS EN DESSOUS DE CETTE LIGNE

    Date creerDate()
    {
        Date nvDate = new Date();

        Console.Write("Annee : ");
        nvDate.annee = Utilisateur.saisirEntier();

        do
        {
            Console.Write("Mois : ");
            nvDate.mois = Utilisateur.saisirEntier();
        } while (nvDate.mois < 1 || nvDate.mois > 12);

		int jourMax = 31;
		if (nvDate.mois == 4 
			|| nvDate.mois == 6 
			|| nvDate.mois == 9 
			|| nvDate.mois == 11)
		{
			jourMax = 30;
		} else if (nvDate.mois == 2) {
			if (estBissextile(nvDate.annee) == true) {
				jourMax = 29;
			} else {
				jourMax = 28;
			}
		}
        do
        {
            Console.Write("Jour : ");
            nvDate.jour = Utilisateur.saisirEntier();
        } while (nvDate.jour < 1 || nvDate.jour > jourMax);

        return nvDate;
    }

    bool estBissextile(int annee)
    {
        bool estBissextile = false;

		if (annee % 4 == 0 && (annee % 100 != 0 || annee % 400 == 0))
		{
			estBissextile = true;
		}

		return estBissextile;
    }

    /* EXEMPLES DE PROCEDURES ET FONCTIONS :
	
		void uneProcedure(int param1, int param2)
		{
			Console.WriteLine(param1+param2);
		{
		
		int uneFonction(int param1, int param2)
		{
			int resultat = 0;
			resultat = param1 + param2;
			return resultat;
		}
		
		
		*/

    //NE PAS TOUCHER LE CODE EN DESSOUS DE CETTE LIGNE
}


