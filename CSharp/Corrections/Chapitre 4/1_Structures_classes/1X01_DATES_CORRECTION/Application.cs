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
        
        Console.WriteLine("Entrez votre date d'embauche");
        Date dateEmbauche = creerDate();


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

        Console.Write("Mois : ");
        nvDate.mois = Utilisateur.saisirEntier();

        Console.Write("Jour : ");
        nvDate.jour = Utilisateur.saisirEntier();

        return nvDate;
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


