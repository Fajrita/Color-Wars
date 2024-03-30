using UnityEngine;
using Color = UnityEngine.Color;
using UnityEngine.UI;


public class ChangeColor : MonoBehaviour
{
    
    public Image mySprite;
    public CursorManager myCursorManager;
    public Button myButton;


    void Start()
    {
        mySprite = GetComponent<Image>();
    }

    public void ColorSlot()
    {

            switch (myCursorManager.myColor)
            {
                case CursorManager.SelectedColor.Yellow:
                    mySprite.color = Color.yellow;
                    break;
                case CursorManager.SelectedColor.Blue:
                    mySprite.color = Color.blue;
                    break;
                case CursorManager.SelectedColor.Red:
                    mySprite.color = Color.red;
                    break;
                case CursorManager.SelectedColor.Purple:
                    mySprite.color = Color.magenta;
                    break;
                case CursorManager.SelectedColor.Cyan:
                    mySprite.color = Color.cyan;
                    break;
                case CursorManager.SelectedColor.Orange:
                    mySprite.color = Color.magenta;
                    break;
                case CursorManager.SelectedColor.Green:
                    mySprite.color = Color.green;
                    break;
                default:
                    mySprite.color = Color.white;
                    break;
            }
    }

    private void Update()
    {
        if (myCursorManager.isUsingObject) myButton.interactable = false;
        else myButton.interactable = true;
    }

}
