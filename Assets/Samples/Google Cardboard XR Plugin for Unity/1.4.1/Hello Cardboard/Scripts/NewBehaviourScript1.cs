
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls target objects behaviour.
/// </summary>
public class ButtonMedTheater : MonoBehaviour


{
    public void MedClick()
    {
        SceneManager.LoadScene("MainSceneMed");
        //TeleportRandomly();
    }
}
