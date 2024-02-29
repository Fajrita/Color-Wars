using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    public Texture2D baseCursor;
    public Texture2D blueCursor;
    public Texture2D yellowCursor;

    public enum SelectedColor
    {
        Yellow,
        Red,
        Orange,
        Green,
        Cyan,
        Blue,
        Purple,
        Base
    }

    public SelectedColor myColor;

    void Start()
    {
        Cursor.SetCursor(baseCursor, Vector2.zero, CursorMode.ForceSoftware);
        myColor = SelectedColor.Base;
    }

    public void BlueCursor()
    {
        Cursor.SetCursor(blueCursor, Vector2.zero, CursorMode.ForceSoftware);
        myColor = SelectedColor.Blue;
    }

    public void YellowCursor()
    {
        Cursor.SetCursor(yellowCursor, Vector2.zero, CursorMode.ForceSoftware);
        myColor = SelectedColor.Yellow;
    }
}
