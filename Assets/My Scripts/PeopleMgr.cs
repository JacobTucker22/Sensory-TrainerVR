using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMgr : MonoBehaviour
{
     public static PeopleMgr inst;
     public List<Person> people;

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
}
