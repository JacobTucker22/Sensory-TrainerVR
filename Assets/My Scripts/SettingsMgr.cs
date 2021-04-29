using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SettingsMgr : MonoBehaviour
{
     public static SettingsMgr inst;

     public List<UIObjectController> settingObjects;

     public string chosenScene = null;

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

     public void OnPointerClick() {
          StartGame();
     }


     public void StartGame()
     {
          if (chosenScene != null)
          {
               SceneManager.LoadScene(chosenScene);
          }
     }


}
