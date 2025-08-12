using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour{
    public void BtnStart()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void BtnCredits()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void BtnSettings()
    {
        SceneManager.LoadScene("Configs");
    }
    public void BtnExit()
    {
        Application.Quit();
    }
}
