using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_video;
    class Character
    {
        public string characterName;
        public int characterPv;
        public int characterAtk;
        public int characterDef;

        public bool IsAlive()
        {
            if (characterPv <= 0) return false;
            else return true;
        }

        public void Attack(Character foe)
        {
        Console.WriteLine(characterName + " attack " + foe.characterName);
        if (this.characterAtk < foe.characterDef) { Console.WriteLine(this.characterName + " is too weak to give damage"); }
        else { foe.characterPv = foe.characterPv - (this.characterAtk - foe.characterDef); }
        
        }
    }
