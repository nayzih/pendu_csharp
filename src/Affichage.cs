namespace Pendu;

// Cette classe s'occupe d'afficher les choses a l'ecran.
public class Affichage
{
    // Affiche le mot avec des _ pour les lettres non trouvees.
    public void AfficherMot(string mot, string lettresTrouvees)
    {
        for (int i = 0; i < mot.Length; i++)
        {
            if (lettresTrouvees.Contains(mot[i]))
            {
                Console.Write(mot[i] + " ");
            }
            else
            {
                Console.Write("_ ");
            }
        }
        Console.WriteLine();
    }

    // Affiche le nombre d'erreurs restantes.
    public void AfficherErreurs(int erreurs, int max)
    {
        Console.WriteLine("Erreurs : " + erreurs + " / " + max);
    }
}
