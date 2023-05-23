using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject PlayGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoMode()
    {
        MainMenu.SetActive(false);
        PlayGame.SetActive(true);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
