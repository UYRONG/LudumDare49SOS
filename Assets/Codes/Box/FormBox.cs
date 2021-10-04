using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormBox : Box
{

        public override void interact(Cat c){
            float chance = Utils.generateRandom();
            CatFormController cf = c.gameObject.GetComponent<CatFormController>();
            if(chance > 0.0f){
                cf.changeForm(true);
            }
        }
}
