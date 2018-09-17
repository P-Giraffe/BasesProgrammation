using System;

public class Application
{
    public void fonctionPrincipale()
    {
        //DEBUT de votre programme
		Date d = new Date();
		d.afficher();

        String prenom, nom;
        Console.WriteLine("Prenom : ");
        prenom = Utilisateur.saisirTexte();
		if (prenom.StartsWith("P") == true) {
			string prenomMajuscules = prenom.ToUpper();
			Console.WriteLine(prenomMajuscules);
		}
		

        Console.WriteLine("Nom :");
        nom = Utilisateur.saisirTexte();

        Console.WriteLine("Entrez votre date de naissance");
        Date dateNaissance = creerDate();
        Date dateEmbauche = null;
        do
        {
            Console.WriteLine("Entrez votre date d'embauche");
            dateEmbauche = creerDate();
        } while (estPlusRecenteQue(dateNaissance, dateEmbauche) == true);


        Console.WriteLine("Bonjour {0} {1}, voici votre date de naissance :", prenom, nom);
        dateNaissance.afficher();
		
        Console.WriteLine("et voici votre date d'embauche : ");
        dateEmbauche.afficher();

		

        Utilisateur.saisirTexte();
        //FIN de votre programme
    }

    Date creerDate()
    {
        Date nvDate = new Date();
        do
        {
            Console.Write("Année : ");
            nvDate.annee = Utilisateur.saisirEntier();
        } while (nvDate.annee <= 0);

        do
        {
            Console.Write("Mois : ");
            nvDate.mois = Utilisateur.saisirEntier();
        } while (nvDate.mois < 1 || nvDate.mois > 12);

        int jourMax = obtenirJourMax(nvDate.mois, nvDate.annee);
        do
        {
            Console.Write("Jour : ");
            nvDate.jour = Utilisateur.saisirEntier();
        } while (nvDate.jour < 1 || nvDate.jour > jourMax);

        return nvDate;
    }

	int obtenirJourMax(int mois, int annee) {
		int jourMax = 31;
		if (mois == 4 
			|| mois == 6 
			|| mois == 9 
			|| mois == 11) {
			jourMax = 30;
		} else if (mois == 2) {
			if (estBissextile(annee) == true) {
				jourMax = 29;
			} else {
				jourMax = 28;
			}
		}
		return jourMax;
	}

    bool estBissextile(int annee)
    {
        bool estBissextile = false;
		if (annee % 4 == 0 
			&& (annee % 100 != 0 || annee % 400 == 0)) {
			estBissextile = true;
		}

		return estBissextile;
    }

    

    bool estPlusRecenteQue(Date date1, Date date2)
    {
        bool estPlusRecente = true;

        if (date1.annee < date2.annee)
        {
            estPlusRecente = false;
        }
        else if (date1.annee == date2.annee && date1.mois < date2.mois)
        {
            estPlusRecente = false;
        }
        else if (date1.annee == date2.annee && date1.mois == date2.mois && date1.jour <= date2.jour)
        {
            estPlusRecente = false;
        }

        return estPlusRecente;
    }

    //DECLAREZ VOS FONCTIONS EN DESSOUS DE CETTE LIGNE

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


