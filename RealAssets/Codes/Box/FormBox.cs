using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormBox : Box
{

        public override void interact(Cat c){
            float chance = Utils.generateRandom();
            if(chance > 0.5f){
                c.changeform(true);
            }
        }
}
