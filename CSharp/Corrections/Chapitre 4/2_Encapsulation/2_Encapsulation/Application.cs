using System;

public class Application
{
	public void fonctionPrincipale ()
	{
        String prenom, nom;
        Console.WriteLine("Prenom : ");
        prenom = Utilisateur.saisirTexte();		

        Console.WriteLine("Nom :");
        nom = Utilisateur.saisirTexte();

        Console.WriteLine("Entrez votre date de naissance");
        Date dateNaissance = creerDate();
        Date dateEmbauche = null;
        do
        {
            Console.WriteLine("Entrez votre date d'embauche");
            dateEmbauche = creerDate();
        } while (dateNaissance.estPlusRecenteQue(dateEmbauche) == true);


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
		nvDate.remplir();
		return nvDate;
	}
}


