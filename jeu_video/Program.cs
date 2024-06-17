using System;

namespace jeu_video;

class Program
{
    public static void Main(string[] args)
    {

        //initialisation des personages 
        Character character1 = new Character();
        character1.characterName = "Ryu";
        character1.characterPv = 100;
        character1.characterAtk = 15;
        character1.characterDef = 7;

        Character character2 = new Character();
        character2.characterName = "Ken";
        character2.characterPv = 100;
        character2.characterAtk = 10;
        character2.characterDef = 13;

        //ici se deroule le combat
        while (character1.IsAlive() && character2.IsAlive())
        {
            Console.WriteLine(character1.characterName+": "+character1.characterPv+" VS "+character2.characterName+": "+character2.characterPv);
            //personage1 attaque personage2
            Console.WriteLine(character1.characterName+" atttaque "+character2.characterName);
            character1.Attack(character2);
            //personage2 attaque personage2
            Console.WriteLine(character2.characterName + " repond à " + character1.characterName);
            character2.Attack(character1);

            Console.WriteLine("Tour suivant ...");
            Console.ReadLine();

        }
        //personage1 ou personage2 est mort voire les deux
        if (character1.IsAlive()) { Console.WriteLine(character1.characterName + " a gagné!");}
        else { Console.WriteLine(character2.characterName + " a gagné!"); }

    }
}
