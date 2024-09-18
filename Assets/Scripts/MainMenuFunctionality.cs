using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctionality : MonoBehaviour
{
   public void playGame()
    {
        SceneManager.LoadScene("Stage_Select");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void playOrginialBuild()
    {
        SceneManager.LoadScene("og_Build");
    }
    
    public void goToMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void loadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void loadVersionNotes()
    {
        SceneManager.LoadScene("Version_Notes");
    }

    public void Level_01()
    {
        SceneManager.LoadScene("Level_01");
    }
    
    public void Level_02()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void Level_03()
    {
        SceneManager.LoadScene("Level_03");
    }
}
