using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Oasis;

    public bool GameWin;
    public bool GameLose;

    private static GameManager gameManagerIntance;

    public static GameManager GameManagerInstance
    {
        get { return gameManagerIntance; }
    }
    
    public void Start()
    {
        if (gameManagerIntance == null)
        {
            gameManagerIntance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Update()
    {
        if (GameWin)
        {
            SceneManager.LoadScene("Win");
        }

        if (GameLose)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}