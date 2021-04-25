using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SettingsMgr : MonoBehaviour
{
     public static SettingsMgr inst;
     public Button startButton;

     private void Awake()
     {
          inst = this;
     }

     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {

     }

     void OnPointerClick() {
          StartGame();
     }


     void StartGame()
     {
          SceneManager.LoadScene("MainScene");
     }
}
