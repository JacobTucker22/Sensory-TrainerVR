using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
     public float minY, maxY;
     public bool isMovingUp;
     public float randNum;

    // Start is called before the first frame update
    void Start()
    {
          randNum = Random.Range(0, 10);
          minY = transform.position.y;
          maxY = minY + 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
          if (randNum < 6)
          {
               if (randNum < 0)
               {
                    Jump();
               }
               else
               {
                    randNum -= Time.deltaTime;
               }
          }
    }

     void Jump()
     {
          if (transform.position.y < minY)
          {
               isMovingUp = true;
          }
          else if (transform.position.y > maxY)
          {
               isMovingUp = false;
          }

          if (isMovingUp)
          {
               transform.position += transform.up * Time.deltaTime;
          }
          else
          {
               transform.position -= transform.up * Time.deltaTime;
          }
     }

}



