using System;

public class Application
{
	public void fonctionPrincipale ()
	{
		//DEBUT de votre programme
		Console.WriteLine("Prénom");
		String prenom = Utilisateur.saisirTexte();
		Console.WriteLine("Quand êtes-vous né ?");
		Date naissance = creerDate();
		
		Console.WriteLine("Quand avez-vous été embauché ?");
		Date embauche = creerDate();
		//FIN de votre programme
	}

	
	void afficherDate(Date d)
	{
		Console.WriteLine ("Date : " + d.jour + "/"+d.mois+"/"+d.annee);
	}

	Date creerDate()
	{
		Date nvDate = new Date ();

		Console.Write ("Entrez l'année : ");
		nvDate.annee = Utilisateur.saisirEntier ();
		Console.Write ("Entrez le mois : ");
		nvDate.mois = Utilisateur.saisirEntier ();
		Console.Write ("Entrez le jour : ");
		nvDate.jour = Utilisateur.saisirEntier ();

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


