using System;
using System.Collections.Generic;

public class Application
{
	private List<RectangleGeo> listeRectangles = new List<RectangleGeo> ();

	void afficherListeRectangles ()
		{
			Console.WriteLine ("Choisissez un rectangle à afficher :");
			RectangleGeo rChoisi = choisirRectangle();
			if (rChoisi != null) {
				rChoisi.dessiner ();
			} else {
				Console.WriteLine ("Aucun rectangle à afficher");
			}
		}

		RectangleGeo choisirRectangle()
		{
			RectangleGeo rectangleChoisi = null;
			if (listeRectangles.Count > 0) {
				int choixIndice = 0;
				do {
					Console.WriteLine ("Choisir un rectangle : ");
					for (int i = 0; i < listeRectangles.Count; i++) {
						RectangleGeo r = listeRectangles [i];
						Console.WriteLine ("{0} - Rectangle {1}x{2}", (i + 1), r.getLargeur (), r.getHauteur ());
					}
					Console.Write ("Num voulu : ");
					choixIndice = Utilisateur.saisirEntier();
					choixIndice = choixIndice - 1;
				} while(choixIndice < 0 || choixIndice >= listeRectangles.Count);
			
				rectangleChoisi = listeRectangles [choixIndice];
			}
			return rectangleChoisi;
		}
		

		void AjouterRectangle ()
		{
			string nom;
			int lar=0;
			int hau=0;
			RectangleGeo nvRect = null;
			if (questionOuiNon ("Voulez vous garder les valeurs par defaut?") == true) {
				nvRect = new RectangleGeo ();
				nom = "Nouveau Rect";
			} else {
				Console.WriteLine("Nom du nouveau Rectangle");
				nom = Utilisateur.saisirTexte();
				Console.WriteLine("Quel est la largeur du nouveau rectangle");
				lar = Utilisateur.saisirEntier();
				Console.WriteLine("Quel est la hauteur du nouveau rectangle");
				hau = Utilisateur.saisirEntier();
				nvRect =  new RectangleGeo(lar,hau);
			}
			listeRectangles.Add(nvRect);

			Console.Clear();
			Console.WriteLine("             Vous avez ajouté un nouveau rectangle !\n\n");
			
		}

		bool questionOuiNon(String question) {
			String result = "";
			do {
				Console.WriteLine (question + " (o/n)");
				result = Utilisateur.saisirTexte();
			} while (result != "o" && result != "n");

			return result == "o";
		}

		void supprimer ()
		{
			RectangleGeo rectChoisi = choisirRectangle ();
			if (rectChoisi != null) {
				if (questionOuiNon ("Voulez vous vraiment supprimer ce rectangle?") == true) {
					listeRectangles.Remove (rectChoisi);
				}
			}
		}

		void afficherMenu ()
		{
			int choixUtilisateur = 0;
			do {
				Console.WriteLine ("0 Quitter               1 Afficher");
				Console.WriteLine ("");
				Console.WriteLine ("2 Ajouter               3 Supprimer                        ");
				Console.WriteLine ("");
				Console.Write ("Tapez un numero : ");

				do {
					choixUtilisateur = Utilisateur.saisirEntier();
				} while (choixUtilisateur < 0 || choixUtilisateur > 6);

				switch (choixUtilisateur) {
				case 0:
					Console.WriteLine("Au revoir");
					break;
				case 1:
					afficherListeRectangles();
					break;
				case 2:
					AjouterRectangle ();
					break;
				case 3:
					supprimer ();
					break;
				default:
					Console.WriteLine("Valeur inconnue");
					break;
				}

			} while (choixUtilisateur != 0);
		}


        public void fonctionPrincipale()
        {
			Console.WriteLine("hello");
			listeRectangles.Add(new RectangleGeo(5, 5));
			listeRectangles.Add(new RectangleGeo(10, 5));
			listeRectangles.Add(new RectangleGeo(5, 5));
			listeRectangles.Add(new RectangleGeo(20, 30));
			listeRectangles.Add(new RectangleGeo(5,5));

			RectangleGeo c = new RectangleGeo(5,5);
			c.deplacerHorizontalement(3);
			c.deplacerVerticalement(2);
			c.dessiner();

			afficherMenu ();
        }
}


