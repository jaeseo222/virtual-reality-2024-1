using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class W04_ChangeScene : MonoBehaviour
{
    public void LoadScene_1()
    {
        SceneManager.LoadScene("W04_HW_Scene_1");
    }
    public void LoadScene_2()
    {
        SceneManager.LoadScene("W04_HW_Scene_2");
    }

}
