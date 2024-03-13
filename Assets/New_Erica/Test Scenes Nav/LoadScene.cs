using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public int myScene;


    public void LoadMyScene()
    {
        SceneManager.LoadScene(myScene);
    }



}

