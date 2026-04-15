namespace Pendu;

// Cette classe contient la liste des mots et tire un mot au hasard.
public class Mots
{
    private string[] liste = { "chat", "maison", "ordinateur", "voiture", "chocolat", "ecole" };

    public string ChoisirMot()
    {
        Random r = new Random();
        int index = r.Next(liste.Length);
        return liste[index];
    }
}
