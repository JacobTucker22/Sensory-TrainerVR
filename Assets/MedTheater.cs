using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MedTheater : MonoBehaviour
{

    public void MedClick()
    {
        SceneManager.LoadScene("MainSceneMed");
        //TeleportRandomly();
    }

}
