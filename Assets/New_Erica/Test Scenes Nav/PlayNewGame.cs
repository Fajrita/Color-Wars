using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayNewGame : MonoBehaviour
{

    public MenuManager2 myManager;
    public GameObject myGO;


    public void NewGame()
    {
        if (myManager.savedGame) myGO.SetActive(true);
        else SceneManager.LoadScene(2);
    }



}
