//-----------------------------------------------------------------------
// <copyright file="CameraPointer.cs" company="Google LLC">
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Sends messages to gazed GameObject.
/// </summary>
public class CameraPointer : MonoBehaviour
{
    private const float _maxDistance = Mathf.Infinity;
    private GameObject _gazedAtObject = null;

     public LayerMask clickables;
     public GameObject yawNode, pitchNode;


     /// <summary>
     /// Update is called once per frame.
     /// </summary>
     public void Update()
    {
        // Casts ray towards camera's forward direction, to detect if a GameObject is being gazed
        // at.
        RaycastHit hit;
          
        if (Physics.Raycast(transform.position, transform.forward, out hit, _maxDistance, clickables))
        {
               //Debug.Log("HIt");
               // GameObject detected in front of the camera.
               if (_gazedAtObject != hit.transform.gameObject)
            {
                // New GameObject.
                _gazedAtObject?.SendMessage("OnPointerExit");
                _gazedAtObject = hit.transform.gameObject;
                _gazedAtObject.SendMessage("OnPointerEnter");
            }
        }
        else
        {
               //Debug.Log("miss");
            // No GameObject detected in front of the camera.
            _gazedAtObject?.SendMessage("OnPointerExit");
            _gazedAtObject = null;
        }

        //Click to simulate tapped screen
        if(Input.GetMouseButtonDown(0))
          {
               if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("MainMenu"))
               {
                    SceneManager.LoadScene("MainMenu");
               }
               _gazedAtObject?.SendMessage("OnPointerClick");
          }

          //editor arrow controls for testing
          if (Input.GetKey(KeyCode.LeftArrow))
          {
               yawNode.transform.localEulerAngles -= Vector3.up * 30 * Time.deltaTime;
          }

          if (Input.GetKey(KeyCode.RightArrow))
          {
               
               yawNode.transform.localEulerAngles += Vector3.up * 30 * Time.deltaTime;
          }

          if (Input.GetKey(KeyCode.UpArrow))
          {
               pitchNode.transform.localEulerAngles -= Vector3.right * 30 * Time.deltaTime;

          }

          if (Input.GetKey(KeyCode.DownArrow))
          {
               pitchNode.transform.localEulerAngles += Vector3.right * 30 * Time.deltaTime;
          }

          // Checks for screen touches.
          if (Google.XR.Cardboard.Api.IsTriggerPressed)
        {
               if(SceneManager.GetActiveScene() != SceneManager.GetSceneByName("MainMenu"))
               {
                    SceneManager.LoadScene("MainMenu");
               }
            _gazedAtObject?.SendMessage("OnPointerClick");
        }
    }
}
