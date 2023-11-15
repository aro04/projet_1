using System;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Principal;

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
            case "8":
                Environment.Exit(8);
                break;
            default:
                {
                    afficherMessageErreur();
                }
                break;
        }

    } while (choice !="8");
    
    

}

void afficherMessageErreur()
{
    Console.WriteLine("Le choix n'est pas valide...");
}

void ajouterUnAnimal()
{
    int i = 0;
    for (i = 0; i <= 10; i++)
    {
        if (tableau[i, 1] == null)
        {
            traiterAjoutAnimal(i);
            break;
        
        }
        
    }
 
    
}
string choisirlacouleur()
{

    string couleur;
    do
    {
        Console.WriteLine("veuillez saisir la couleur de l'animal: ");
        couleur = Console.ReadLine();
    }

    while (couleur != "rouge" && couleur != "bleu" && couleur != "violet");
    return couleur;    
}

void traiterAjoutAnimal(int i)
{
    Console.Write("veuillez saisir le type de l'animal: \n ");
    string type = Console.ReadLine();
    tableau[i, 1] = type;
    Console.Write("veuillez saisir le nom de l'animal:\n");
    string nom = Console.ReadLine();
    tableau[i, 2] = nom;
    Console.Write("veuillez saisir l'age de l'animal: \n");
    string age = Console.ReadLine();
    tableau[i, 3] = age;
    Console.Write("veuillez saisir le poids de l'animal: \n");
    string poids = Console.ReadLine();
    tableau[i, 4] = poids;
    tableau[i, 5] = choisirlacouleur();
    Console.Write("veuillez saisir le nom du propriétaire de l'animal: \n");
    string proprietaire = Console.ReadLine();
    tableau[i, 6] = proprietaire;
}
void voirListeAnimauxPension()
{
    Console.WriteLine(" --------------------------------------------------------------------------------------------------   ");
    Console.WriteLine("ID |   TYPE   |       NOM      |       AGE      |    POIDS   |    COULEUR   |    PROPRIETAIRE    |     ");
    Console.WriteLine(" --------------------------------------------------------------------------------------------------    ");
    for (int i = 0; i < 10; i++)
    {
        if (tableau[i, 1] != null)

        {
            Console.WriteLine(String.Format("{0,-6}{1,-12}{2,-20}{3,-15}{4,-15}{5,-20}{6,-10}", i.ToString(), tableau[i, 1], tableau[i, 2], tableau[i, 3], tableau[i, 4], tableau[i, 5], tableau[i, 6]));
        }
    }
}

void voirListePropriétaire()
{
    Console.WriteLine(" ------------------------------------------------------------------------------------------  ");
    Console.WriteLine("|    PROPRIETAIRE    |  ");
    Console.WriteLine(" ------------------------------------------------------------------------------------------  ");
    for (int i = 0; i < 10; i++)
     
    {
        Console.WriteLine(tableau[i,6]);
    }
}


void voirNombreTotalAnimaux()
{
    Console.WriteLine(" ---------------------------------------------------------------------------------------");
    Console.WriteLine("|   NOMBRE ANIMAUX |  ");
    Console.WriteLine(" ---------------------------------------------------------------------------------------");
    int NombreTotalDesAnimaux = 0;

    for (int i = 0; i < 10; i++)
    {
        if (tableau[i, 1] != null)
        {
            NombreTotalDesAnimaux = i + 1;
            
        }
    }

    Console.WriteLine(NombreTotalDesAnimaux);

}

void voirPoidsTotalAnimaux()
{
    Console.WriteLine(" ---------------------------------------------------------------------------------------");
    Console.WriteLine("|   POIDS TOTAL |  ");
    Console.WriteLine(" ---------------------------------------------------------------------------------------");
    int PoidsTotalAnimaux =0;
    for (int i = 0; i < 10; i++)
    {
        if (tableau[i, 4] != null)
        {
            PoidsTotalAnimaux = PoidsTotalAnimaux +int.Parse( tableau[i, 4]);

        }
    }

    Console.WriteLine(PoidsTotalAnimaux);
}

void extraireAnimauxSelonCouleurs()
{
    string couleur = choisirlacouleur();
    Console.WriteLine(" --------------------------------------------------------------------------------------------------   ");
    Console.WriteLine("ID |   TYPE ANIMAL    |       NOM      |         COULEUR        |        ");
    Console.WriteLine(" --------------------------------------------------------------------------------------------------    ");
    for (int i=0;i<10; i++)
    {
        if (tableau[i,5]== couleur)
        {
            Console.WriteLine(i.ToString() + "\t" + tableau[i, 1] + "\t\t\t" + tableau[i, 2] + "\t\t" + tableau[i, 5]);
        }
    
    }

}
int TrouverDernierID()
{
    int DernierID;
    int i = 0;
    for ( i=0;i<10;i++)
    {
        if (tableau[i,1]!= null)
        {
            DernierID = i++;
        } 
    }
    return i;
}
    


string entrerId()
{
    int DernierID = TrouverDernierID();
    string ID;
    do
    {
        Console.WriteLine("VEUILLEZ SAISIR LE ID DE L'ANIMAL: ");
        ID = Console.ReadLine();
    }
    while (Int32.Parse(ID)>= DernierID);
    return ID;
}
void retirerUnAnimalDeListe()
{   
    string ID = entrerId();
    for (int i = 0; i < 10; i++)
    {
        if (ID == i.ToString())
        {

            tableau[i, 0] = " ";
            tableau[i, 1] = " ";
            tableau[i, 2] = " ";
            tableau[i, 3] = " ";
            tableau[i, 4] = " ";
            tableau[i, 5] = " ";
            tableau[i, 6] = " ";
        }
        
    }
    voirListeAnimauxPension();
}
  