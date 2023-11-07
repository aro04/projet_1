string[,] tableau = new string[10, 7];
startTheMachine();

void afficherMenu()
{
    Console.WriteLine("\t ------------application de gestion de la liste des animaux en pensions--------------\n");
    Console.WriteLine("1- Ajouter un animal");
    Console.WriteLine("2- liste de tous les animaux en pension");
    Console.WriteLine("3- liste de tous les propriétaires");
    Console.WriteLine("4- le nombre total d’animaux en pension");
    Console.WriteLine("5- Voir le poids total de tous les animaux en pension");
    Console.WriteLine("6- Voir la liste des animaux d’une couleur");
    Console.WriteLine("7- Retirer un animal");
    Console.WriteLine("8- Quiter");
    Console.Write("\t \n Iserer votre choix: ");

}

void startTheMachine()
{
    string choice;
    do
    {
        afficherMenu();
        choice = Console.ReadLine();
     
        
    } while (choice != "8");
    switch (choice)

    {
        case "1":
            ajouterUnAnimal();
            break;
        case "2":
            voirListeAnimauxPension();
            break;
        case "3":
            voirListePropriétaire();
            break;
        case "4":
            voirNombreTotalAnimaux();
            break;
        case "5":
            voirPoidsTotalAnimaux();
            break;
        case "6":
            extraireAnimauxSelonCouleurs();
            break;
        case "7":
            retirerUnAnimalDeListe();
            break;
        default:
            {
                afficherMessageErreur();
                Console.Clear();
                afficherMenu();
                break;
            }

    }


}

void selectChoice(string choice)
{
   
}

void afficherMessageErreur()
{
    Console.WriteLine("Le choix n'est pas valide...");
}

void ajouterUnAnimal()
{
    Console.Write("veuillez saisir le type de l'animal: ");
    string type= Console.ReadLine();
    Console.Write("veuillez saisir le nom de l'animal");
    string nom = Console.ReadLine();
    Console.Write("veuillez saisir l'age de l'animal");
    int age = int.Parse(Console.ReadLine());
    Console.Write("veuillez saisir le poids de l'animal");
    int poids = int.Parse(Console.ReadLine());
    Console.Write("veuillez saisir la couleur de l'animal");
    string couleur = Console.ReadLine();
    Console.Write("veuillez saisir le nom du propriétaire de l'animal");
    string propriétaire = Console.ReadLine();
}

void traiterAjoutAnimal(int i)
{

}

void voirListeAnimauxPension()
{

}

void voirListePropriétaire()
{

}

void voirNombreTotalAnimaux()
{

}

void voirPoidsTotalAnimaux()
{

}

void extraireAnimauxSelonCouleurs()
{

}

void retirerUnAnimalDeListe()
{

}