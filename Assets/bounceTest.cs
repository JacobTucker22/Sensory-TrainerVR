using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceTest : MonoBehaviour
{
     public float minY, maxY;
     public bool isMovingUp;

    // Start is called before the first frame update
    void Start()
    {
          minY = transform.position.y;
          maxY = minY + 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
          if(transform.position.y < minY)
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
