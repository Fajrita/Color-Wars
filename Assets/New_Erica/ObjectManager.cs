using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ObjectManager : MonoBehaviour
{

    bool hasObject;
    bool isInteractingUI;

    public EventSystem EventSystemManager;

    private Vector3 mousePos;
    private Vector3 objectPos;
    public GameObject mine;
    public GameObject obj2;
    public GameObject obj3;

    public CursorManager myCursor;


    public enum SelectedObject
    {
        Empty,
        Mine,
        Object2,
        Object3,
        Object4,
    }

    public SelectedObject myObject;

    private void Update()
    {
        if (EventSystemManager.IsPointerOverGameObject()) isInteractingUI = true;
        else isInteractingUI = false; //check if you're interacting with UI
    }

    public void DropMyObject(InputAction.CallbackContext callbackContext)
    {

        if (callbackContext.started)
        {
            if (hasObject && !isInteractingUI) //if you're interacting with UI, you will not drop the object
            {
                switch (myObject)
                {
                    case SelectedObject.Mine:
                        Debug.Log("mine");
                        InstanciateMyMine();
                        break;
                    case SelectedObject.Object2:
                        Debug.Log("ob2");
                        InstanciateMyObj2();
                        break;
                    case SelectedObject.Object3:
                        Debug.Log("ob3");
                        InstanciateMyObj3();
                        break;
                    case SelectedObject.Object4:
                        //instanciate object4
                        break;
                    default:
                        break;

                }
            }
        }
    }

    public void SelectMine()
    {
        hasObject = true;
        myObject = SelectedObject.Mine;
    }

    public void SelectObject2()
    {
        hasObject = true;
        myObject = SelectedObject.Object2;
    }

    public void SelectObject3()
    {
        hasObject = true;
        myObject = SelectedObject.Object3;
    }

    public void SelectObject4()
    {
        hasObject = true;
        myObject = SelectedObject.Object4;
    }

    public void DeselectObjects()
    {
        myObject = SelectedObject.Empty;
        hasObject = false;
        Cursor.SetCursor(myCursor.baseCursor, Vector2.zero, CursorMode.ForceSoftware);

    }


    void InstanciateMyMine()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10f; //because z of MainCamerea in the scene is -10, so by stating mousePov.z=10 it will clone my obj on z=0;
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(mine, objectPos, Quaternion.identity);
        DeselectObjects();
    }

    void InstanciateMyObj2()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10f;
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(obj2, objectPos, Quaternion.identity);
        DeselectObjects();

    }

    void InstanciateMyObj3()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10f;
        objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(obj3, objectPos, Quaternion.identity);
        DeselectObjects();

    }


}
