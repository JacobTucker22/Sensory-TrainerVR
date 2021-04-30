using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIObjectController : MonoBehaviour
{
     public Material InactiveMaterial;
     public Material GazedAtMaterial;
     public Material SelectedMaterial;

     private Renderer _myRenderer;
     private Vector3 _startingPosition;

     public string myScene = "[Scene Name here]";
     public bool isSelected;


     // Start is called before the first frame update
     void Start()
    {
          _startingPosition = transform.localPosition;
          _myRenderer = GetComponent<Renderer>();
          SetMaterial(false);
     }

     private void Update()
     {
          transform.Rotate(transform.forward, 0.3f);
          if(isSelected)
          {
               _myRenderer.material = SelectedMaterial;
          }
     }

     public void OnPointerEnter()
     {
          //
          Debug.Log("Pointer Entered");
          SetMaterial(true);
     }

     public void OnPointerExit()
     {
          SetMaterial(false);
     }

     public void OnPointerClick()
     {
          if (tag == "StartObject")
          {
               SceneManager.LoadScene(SettingsMgr.inst.chosenScene);
               
          }
          else if (tag == "QuitObject")
          {
               Application.Quit();
          }
          else
          {
               SettingsMgr.inst.chosenScene = myScene;
          }

 
          foreach(UIObjectController obj in SettingsMgr.inst.settingObjects)
          {
               obj.isSelected = false;
               obj.SetMaterial(false);
          }

          isSelected = true;
     }

     private void SetMaterial(bool gazedAt)
     {
          if (!isSelected)
          {
               if (InactiveMaterial != null && GazedAtMaterial != null)
               {
                    _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
               }
          }
     }


}
