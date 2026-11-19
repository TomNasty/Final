using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        MusicManager.instance.PlayMusic("MenuTheme");
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
