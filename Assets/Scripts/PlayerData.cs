using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public string playerName;
    
   
    
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()
    {
       
        SceneManager.LoadScene(1);
       

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReadStringInput(string input)
    {
        playerName = input;
        Debug.Log("PLayer name: " + playerName);
    }
}