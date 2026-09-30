using System.Globalization;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

        Console.WriteLine("Mon nom est Eliott Roth et mon jeu préféré est Arc Raider");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

        Console.WriteLine("Quel est ton prénom?");
        string prenom = Console.ReadLine();
        Console.WriteLine("Quel est ton age?");

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
{
            Console.WriteLine("Tu es majeur");
        }
        else
{           
            Console.WriteLine("Tu es mineur");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("Combien d'euro as-tu?");
        float nombreDEuro = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("Magasin:");
        Console.WriteLine("1. épée - 5 euro");
        Console.WriteLine("2. dague - 10 euro");
        Console.WriteLine("3. ak47 - 1899 euro");
        Console.WriteLine("4. tank - 139 999 euro");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Choisis une arme en ecrivant son muméro");
        string armeChoisie = Console.ReadLine();

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        bool asseDArgent = false;
        if (Convert.ToInt32(armeChoisie) == 1)
        { 
            asseDArgent = nombreDEuro >= 5;
        }
        if (Convert.ToInt32(armeChoisie) == 2)
        {
            asseDArgent = nombreDEuro >= 10;
        }
        if (Convert.ToInt32(armeChoisie) == 3)
        {
            asseDArgent = nombreDEuro >= 1899;
        }
        if (Convert.ToInt32(armeChoisie) == 4)
        {
            asseDArgent = nombreDEuro >= 139999;
        }

        if (asseDArgent = true)
        {
            if (age >= 18)
            {
                Console.WriteLine("Ton arme a bien été achetée");
            }
            else
            {
                Console.WriteLine("Tu n'as pas pu acheter l'arme car tu es mineur");
            }
        }
        else
        {
            Console.WriteLine("Tu n'as pas assé d'argent pour acheter cette arme");
        }
            

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}