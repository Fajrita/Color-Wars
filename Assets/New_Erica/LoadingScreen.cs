using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] Image barImage;
    float myLoading;
    public GameObject myParent;

    public PlayerInput playerInput;
    public EnemySpawn enemyScript;
    public MachineGunShoot dispUR;
    public MachineGunShoot dispUL;
    public MachineGunShoot dispDR;
    public MachineGunShoot dispDL;

    public GameObject level;



    void Update()
    {
        myLoading += Time.deltaTime;
        barImage.fillAmount = myLoading * 0.35f;

        if (barImage.fillAmount >= 1)
        {
            Invoke("Activation", 1.5f);
            myParent.SetActive(false);
        }

    }

    void Activation()
    {
        playerInput.enabled = true;
        enemyScript.enabled = true;
        level.SetActive(false);
        LevelOne();
    }

    void LevelOne()
    {
        dispUR.enabled = true;
    }

    void LevelTwo()
    {
        dispUR.enabled = true;
        dispDL.enabled = true;
    }

    void LevelThree()
    {
        dispUR.enabled = true;
        dispDL.enabled = true;
        dispUL.enabled = true;
        dispDR.enabled = true;
    }

}
