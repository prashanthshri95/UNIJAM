using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class wanderer : MonoBehaviour
{
  private Vector3 directionVector;
  private Transform transform;
  public float speed = 10;
  private Rigidbody2D rb;
  //private Animator anim;
  private Transform temp;
  private float nextActionTime = 0.0f;
  public float period = 0.5f;


    void Start()
    {
      transform = GetComponent<Transform>();
      temp = transform;
      rb = GetComponent<Rigidbody2D>();
      //anim = GetComponentInChildren<Animator>();
      //anim.SetFloat("Speed",1);
      //ChangeDirection();
      Physics2D.IgnoreLayerCollision(8, 9);


    }

    // Update is called once per frame
    void Update()
    {
      if (transform == temp && Time.time > nextActionTime) {
        nextActionTime = Time.time + period;
        ChangeDirection();
        Debug.Log("the same");
        Physics2D.IgnoreLayerCollision(8, 9);

      }
      Move();
    }

    private void Move() {
      rb.MovePosition(transform.position+directionVector * speed *Time.deltaTime);
    }

    void ChangeDirection()
    {
      int direction = UnityEngine.Random.Range(0,4);

      switch(direction) {
        case 0:
          //upright
          directionVector = new Vector3(1,(float)0.5,0);
          break;
        case 1:
          //downleft
          directionVector = new Vector3(-1,(float)(-0.5),0);
          break;
        case 2:
          //UpLeft
          directionVector = new Vector3(-1,(float)0.5,0);
          break;
        case 3:
          //downrght
          directionVector = new Vector3(1,(float)(-0.5),0);
          break;
        default: //upright
          directionVector = new Vector3(1,(float)0.5,0);
          break;
      }
      //UpdateAnimation();
      temp.position = transform.position;
    }

    void OnCollisionEnter2D(Collision2D col) {
     Debug.Log("OnCollisionEnter2D");
          if(col.gameObject.name == "pancake(Clone)"){
                Debug.Log("success");
                this.gameObject.SetActive(false);
          }
      Vector3 temp = directionVector;
      ChangeDirection();
      int i = 0;
      while (temp == directionVector) {
        i++;
        ChangeDirection();
      }
      Move();
      Debug.Log(i);
    }

    //void UpdateAnimation(){

      //anim.SetFloat("Horizontal",(float)Math.Round(directionVector.x));
      //anim.SetFloat("Vertical",(float)Math.Round(directionVector.y));
    //}
}
