using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovinghouseUD : MonoBehaviour
{
      public float minX=2f;
      public float maxX=3f;
      public float minY=2f;
      public float maxY=3f;
      // Use this for initialization
      void Start () {

          minX=transform.position.x;
          maxX=transform.position.x+1f;
          minY=transform.position.y;
          maxY=transform.position.y+0.5f;

      }

      // Update is called once per frame
      void Update () {
        float xtransform = Mathf.PingPong(Time.time*2,maxX-minX)+minX;
        //float ytransform = Mathf.PingPong(Time.time*2,maxY-minY)+minY;
        float ytransform = -Mathf.PingPong(Time.time,maxY-minY)+minY;
        transform.position = new Vector3(xtransform,ytransform, transform.position.z);


      }
}
