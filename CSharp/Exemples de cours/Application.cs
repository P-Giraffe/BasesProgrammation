using System;



public class Application
{
	public void fonctionPrincipale ()
	{
		//DEBUT de votre programme
		
int a = 10;
if (a < 100) {
	int b = 20;
	a = a - b;
}
Console.WriteLine(a);

		Utilisateur.saisirTexte();
		//FIN de votre programme
	}

	void convertisseur(){
		double cm, pouces;
		const double TAUX_POUCES_CM = 2.54;
        Console.Write("Entrez la mesure en pouces : ");
        pouces = Utilisateur.saisirReel();
        cm = pouces * TAUX_POUCES_CM;
        Console.WriteLine(pouces + " pouces -> " + cm + " cm");
	}
}


