using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelportBox : Box
{

        public override void interact(Cat c){
            float chance = Utils.generateRandom();
            if(chance > 0.5f){
                c.teleport(new Vector2(0,0));
            }
        }
}
