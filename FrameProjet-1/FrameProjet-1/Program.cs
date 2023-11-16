using System;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Principal;

string[,] tableau = new string[10, 7];
tableau[0, 1] = "Lapin";
tableau[1, 1] = "Chien";
tableau[2, 1] = "Chat";
tableau[3, 1] = "Poisson";
tableau[4, 1] = "Lapin";
tableau[5, 1] = "Poisson";

tableau[0, 2] = "Lap";
tableau[1, 2] = "Chio";
tableau[2, 2] = "Chaton";
tableau[3, 2] = "Po";
tableau[4, 2] = "Lapinou";
tableau[5, 2] = "Polo";

tableau[0, 3] = "1";
tableau[1, 3] = "3";
tableau[2, 3] = "5";
tableau[3, 3] = "12";
tableau[4, 3] = "8";
tableau[5, 3] = "2";

tableau[0, 4] = "20";
tableau[1, 4] = "5";
tableau[2, 4] = "4";
tableau[3, 4] = "15";
tableau[4, 4] = "17";
tableau[5, 4] = "9";

tableau[0, 5] = "bleu";
tableau[1, 5] = "rouge";
tableau[2, 5] = "rouge";
tableau[3, 5] = "violet";
tableau[4, 5] = "rouge";
tableau[5, 5] = "violet";

tableau[0, 6] = "dada";
tableau[1, 6] = "neny";
tableau[2, 6] = "kiady";
tableau[3, 6] = "sanda";
tableau[4, 6] = "aro";
tableau[5, 6] = "feno";



startTheMachine();


void afficherMenu()
{
   
    Console.WriteLine("1- Ajouter un animal");
    Console.WriteLine("2- Voir la liste de tous les animaux en pension");
    Console.WriteLine("3- Voir liste de tous les propriétaires");
    Console.WriteLine("4- Voir le nombre total d’animaux en pension");
    Console.WriteLine("5- Voir le poids total de tous les animaux en pension");
    Console.WriteLine("6- Voir la liste des animaux d’une couleur");
    Console.WriteLine("7- Retirer un animal");
    Console.WriteLine("8- Quiter");
    Console.Write("\t\n ");

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
        Console.WriteLine("Veuillez saisir la couleur de l'animal:\n ");
        couleur = Console.ReadLine();
    }

    while (couleur != "rouge" && couleur != "bleu" && couleur != "violet");
    Console.WriteLine("Veuillez saisir la bonne couleur de l'animal:\n ");
    return couleur;    
}

void traiterAjoutAnimal(int i)
{
    Console.Write("Veuillez saisir le type de l'animal:\n ");
    string type = Console.ReadLine();
    tableau[i, 1] = type;
    Console.Write("Veuillez saisir le nom de l'animal:\n");
    string nom = Console.ReadLine();
    tableau[i, 2] = nom;
    Console.Write("Veuillez saisir l'age de l'animal: \n");
    string age = Console.ReadLine();
    tableau[i, 3] = age;
    Console.Write("Veuillez saisir le poids de l'animal: \n");
    string poids = Console.ReadLine();
    tableau[i, 4] = poids;
    tableau[i, 5] = choisirlacouleur();
    Console.Write("Veuillez saisir le nom du propriétaire de l'animal: \n");
    string proprietaire = Console.ReadLine();
    tableau[i, 6] = proprietaire;
}
void voirListeAnimauxPension()
{
    Console.WriteLine(" --------------------------------------------------------------------------------------------------   ");
    Console.WriteLine("ID |   TYPE ANIMAL   |      NOM     |   AGE  |    POIDS   |    COULEUR   |    PROPRIÉTAIRE    |     ");
    Console.WriteLine(" ----------------------------------------------------------------------------------------------------    ");
    for (int i = 0; i < 10; i++)
    {
        if (tableau[i, 1] != null && tableau[i,1]!= " ")

        {
            Console.WriteLine(String.Format("{0,-10}{1,-15}{2,-15}{3,-11}{4,-12}{5,-18}{6,-10}", i.ToString(), tableau[i, 1], tableau[i, 2], tableau[i, 3], tableau[i, 4], tableau[i, 5], tableau[i, 6]));
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
    Console.WriteLine("|  NOMBRE ANIMAUX |  ");
    Console.WriteLine(" ---------------------------------------------------------------------------------------");
    int NombreTotalAnimaux = 0; 
    for (int i = 0; i < tableau.GetLength(0); i++)
    {
        if (tableau[i,1]!=null)
            {
                NombreTotalAnimaux++;
            }
        
    }

    Console.WriteLine(NombreTotalAnimaux);
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
    
    int i = 0;
    for ( i=0;i<10;i++)
    {
        if (tableau[i,1]!= null)
        {
           i = i++;
        } 
    }
    return i;
}

bool EntierPositif(string ID)
{
    int result;
    return Int32.TryParse(ID, out result) && result >= 0;
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
    while (!EntierPositif(ID) || Int32.Parse(ID)>= DernierID);
    return ID;
}
void retirerUnAnimalDeListe()
{
    int i = 0;
    string ID = entrerId();
    for ( i = 0; i < 10; i++)
    {
        if (ID == i.ToString())
        {
            tableau[i, 0] = null;
            tableau[i, 1] = null;
            tableau[i, 2] = null;
            tableau[i, 3] = null;
            tableau[i, 4] = null;
            tableau[i, 5] = null;
            tableau[i, 6] = null;
            
        }
    }
    voirListeAnimauxPension();
}
  