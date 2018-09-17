using System;

public class Utilisateur
{
	/// <summary>
	/// Fonction permettant de demander la saisie d'une valeur entiere a l'utilisateur
	/// </summary>
	/// <returns>la valeur entiere saisie par l'utilisateur.</returns>
	public static int saisirEntier()
	{
		int val = -1;
		bool erreurSaisie = false;
		do
		{
			try
			{
				val = int.Parse(Console.ReadLine());
				erreurSaisie = false;
			}
			catch (Exception)
			{
				Console.WriteLine("Veuillez saisir une valeur entiere");
				erreurSaisie = true;
			}
		} while (erreurSaisie);

		return val;
	}

	/// <summary>
	/// Fonction permettant de demander la saisie d'une valeur reelle a l'utilisateur
	/// </summary>
	/// <returns>la valeur reelle saisie par l'utilisateur.</returns>
	public static double saisirReel()
	{
		double val = -1;
		bool erreurSaisie = false;
		do
		{
			try
			{
				val = double.Parse(Console.ReadLine());
				erreurSaisie = false;
			}
			catch (Exception)
			{
				Console.WriteLine("Veuillez saisir une valeur double");
				erreurSaisie = true;
			}
		} while (erreurSaisie);

		return val;
	}

	/// <summary>
	/// Fonction permettant de demander la saisie d'une chaine de caracteres a l'utilisateur
	/// </summary>
	/// <returns>la chaine de caracteres saisie par l'utilisateur.</returns>
	public static string saisirTexte()
	{
		return Console.ReadLine();
	}
}
