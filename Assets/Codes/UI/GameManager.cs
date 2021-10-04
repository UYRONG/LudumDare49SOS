using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("UI Object")]
    public Text health;
    public Text fishes;
    public Text state;
    
    [Header("Data Obeject")]
    public Cat cat;
    public GameState gamestate;
    public GameObject lose_pos;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
 
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }
 
    void Start()
    {
        gamestate = GameState.Start;
    }

    public void reachCheckpoint()
    {
        
        SceneManager.LoadScene("WinScene");
    }

    void Update()
    {
        //Set Health and Fish 
        setHealth(cat.health);
        setFish(cat.numOfFish);
        setState(cat.getState());

        //Lose and Win
        if(cat.health <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }

    }

    /*bool checkEnd()
    {
        if(currLevel == && cat.health > 0)
        {
            Debug.Log("success");
            // show game end scene (thank you, play again?)
        }
        else if (currLevel < )
        {
            Debug.Log("Next level page")
        }
        else
        {
            Debug.Log("Lose, play again?")
        }
    }*/

    void setHealth(int h)
    {
        this.health.text = "x " + h.ToString();
    }

    void setFish(int f)
    {
        this.fishes.text = "x " + f.ToString();
    }

    void setState(string s){
        this.state.text = s;
    }

}
