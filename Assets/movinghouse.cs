using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movinghouse : MonoBehaviour
{
      public float minX=2f;
      public float maxX=3f;
      //public float minY=2f;
      //public float maxY=3f;
      // Use this for initialization
      void Start () {

          minX=transform.position.x;
          maxX=transform.position.x+(float)0.5;
          //minY=transform.position.y;
          //maxY=transform.position.y+2;

      }

      // Update is called once per frame
      void Update () {
        float xtransform = Mathf.PingPong(Time.time*2,maxX-minX)+minX;
        transform.position = new Vector3(Mathf.PingPong(Time.time*2,maxX-minX)+minX, xtransform/2, transform.position.z);


      }
}
