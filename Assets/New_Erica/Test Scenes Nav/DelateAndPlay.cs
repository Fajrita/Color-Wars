using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelateAndPlay : MonoBehaviour
{
    public void ImSure()
    {
        Debug.Log("delete progress");
        SceneManager.LoadScene(2);
    }
}
