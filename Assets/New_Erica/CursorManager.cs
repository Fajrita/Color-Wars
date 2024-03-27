using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    public Texture2D baseCursor;
    public Texture2D blueCursor;
    public Texture2D yellowCursor;

    public Texture2D object1;
    public Texture2D object2;
    public Texture2D object3;

    public bool isUsingObject;

    public enum SelectedColor
    {
        Base,
        Yellow,
        Red,
        Orange,
        Green,
        Cyan,
        Blue,
        Purple,
    }

    public SelectedColor myColor;

    void Start()
    {
        Cursor.SetCursor(baseCursor, Vector2.zero, CursorMode.ForceSoftware);
        myColor = SelectedColor.Base;
        isUsingObject = false;

    }

    public void BlueCursor()
    {
        Cursor.SetCursor(blueCursor, Vector2.zero, CursorMode.ForceSoftware);
        myColor = SelectedColor.Blue;
        isUsingObject = false;

    }

    public void YellowCursor()
    {
        Cursor.SetCursor(yellowCursor, Vector2.zero, CursorMode.ForceSoftware);
        myColor = SelectedColor.Yellow;
        isUsingObject = false;

    }


    public void ObjectOne()
    {
        Cursor.SetCursor(object1, new Vector2(object1.width / 2, object1.height / 2), CursorMode.ForceSoftware);
        isUsingObject = true;

    }

    public void ObjectTwo()
    {
        Cursor.SetCursor(object2, new Vector2(object2.width / 2, object2.height / 2), CursorMode.ForceSoftware);
        isUsingObject = true;

    }

    public void ObjectThree()
    {
        Cursor.SetCursor(object3, new Vector2(object3.width / 2, object3.height / 2), CursorMode.ForceSoftware);
        isUsingObject = true;

    }


    public void CursorInPause()
    {
        //SaveCurrentCursor();
        Cursor.SetCursor(baseCursor, Vector2.zero, CursorMode.ForceSoftware);

    }

    public void SaveCurrentCursor()
    {
        
    }

    public void ResumeCursor()
    {

    }
}
