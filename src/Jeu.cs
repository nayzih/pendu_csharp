namespace Pendu;

// Cette classe contient la logique du jeu.
public class Jeu
{
    public void Jouer()
    {
        Mots mots = new Mots();
        Affichage affichage = new Affichage();

        string motATrouver = mots.ChoisirMot();
        string lettresTrouvees = "";
        int erreurs = 0;
        int maxErreurs = 6;

        Console.WriteLine("Bienvenue dans le jeu du pendu !");

        // Boucle principale du jeu.
        while (erreurs < maxErreurs)
        {
            Console.WriteLine();
            affichage.AfficherMot(motATrouver, lettresTrouvees);
            affichage.AfficherErreurs(erreurs, maxErreurs);

            // On verifie si le mot est entierement trouve.
            bool gagne = true;
            for (int i = 0; i < motATrouver.Length; i++)
            {
                if (!lettresTrouvees.Contains(motATrouver[i]))
                {
                    gagne = false;
                }
            }

            if (gagne)
            {
                Console.WriteLine("Bravo ! Vous avez trouve le mot : " + motATrouver);
                return;
            }

            // On demande une lettre au joueur.
            Console.Write("Proposez une lettre : ");
            string saisie = Console.ReadLine();

            if (string.IsNullOrEmpty(saisie))
            {
                Console.WriteLine("Entree vide.");
                continue;
            }

            char lettre = saisie.ToLower()[0];

            // On verifie si la lettre est dans le mot.
            if (motATrouver.Contains(lettre))
            {
                lettresTrouvees += lettre;
                Console.WriteLine("Bonne lettre !");
            }
            else
            {
                erreurs++;
                Console.WriteLine("Mauvaise lettre.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Perdu ! Le mot etait : " + motATrouver);
    }
}
