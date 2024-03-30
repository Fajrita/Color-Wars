using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    public MenuManager2 myManager;
    public GameObject myMap;
    public GameObject myMenu;
    Button myButton;


    private void Start()
    {
        myButton = GetComponent<Button>();
        if (myManager.savedGame) myButton.interactable = true;
        else myButton.interactable = false;
    }

    public void myContinue()
    {
        /*if (myManager.savedGame)
        {
            myMap.SetActive(true);
            myMenu.SetActive(false);
        }*/

        myMap.SetActive(true);
        myMenu.SetActive(false);
    
            
       
    }
}
