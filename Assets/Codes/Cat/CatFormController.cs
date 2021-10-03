using UnityEngine;

public class CatFormController : MonoBehaviour
{
    public Cat c;
    public BoxCollider2D col;
    public SpriteRenderer sprite;

    public GameObject ceil;
    public GameObject ground;

    private float[] col_solid_gas = {3.731574f, 4.576412f, 0.3036778f, -0.3177924f};

    private float[] col_liquid = {3.731574f, 1.60846f, 0.3036778f, -0.128038f};

    private Vector2[] cg_solid_gas = {new Vector2(0f,1.8f), new Vector2(0.1402378f,-2.47f)};
    private Vector2[] cg_liquid = {new Vector2(0f,0.6f), new Vector2(0.1402378f,-0.91f)};

    public void Update(){
        switch(c.state){
            case CatState.Solid:
                applyAnchorPoint(cg_solid_gas);
                break;
            case CatState.Liquid:
                applyAnchorPoint(cg_liquid);
                break;
            case CatState.Gas:
                applyAnchorPoint(cg_solid_gas);
                break;
        }
    }
    public void changForm(bool isRandom){
        c.changeform(isRandom);
        switch(c.state){
            case CatState.Solid:
                applyNewColSize(col_solid_gas);
                break;
            case CatState.Liquid:
                applyNewColSize(col_liquid);
                break;
            case CatState.Gas:
                applyNewColSize(col_solid_gas);
                break;
        }
    }

    public void changeVisibility(){
        c.toggleVisibility();
        Color color = sprite.material.color;
        if(c.isVisible){
            color.a = 1.0f;
            sprite.material.color = color;
        }
        else{
            color.a = 0.5f;
            sprite.material.color = color;
        }
    }

    private void applyNewColSize(float[] col_parameter){
        col.size= new Vector2(col_parameter[0],col_parameter[1]);
        col.offset = new Vector2(col_parameter[2], col_parameter[3]);
    }

    private void applyAnchorPoint(Vector2[] cg_parameter){
        ceil.transform.localPosition = cg_parameter[0];
        ground.transform.localPosition = cg_parameter[1];
    }

}