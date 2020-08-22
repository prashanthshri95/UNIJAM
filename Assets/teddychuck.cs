using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class teddychuck : MonoBehaviour
{

  //public float fireRate=0;
  //public float damage=10;
  //public LayerMask ignore;

  //float timeToFire = 0;
  public Transform firePoint;
  public GameObject pancakePrefab;
  public GameObject player;
  public float bulletForce = 30f;
  public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
      firePoint = transform.Find("FirePoint2");
      if (firePoint==null) {
        Debug.LogError("firpoint not found");
      }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
          Shoot();
        }
    }

    void Shoot() {

      //bullet.SetActive(true);
      //bullet.velocity=transform.forward*bulletForce;

      //rb.velocity=transform.forward*bulletForce;
      //rb.AddForce(firePoint.forward*bulletForce,ForceMode2D.Impulse);
      //Debug.Log(plrb.velocity.normalized);
      //rb.AddForce(plrb.velocity*bulletForce,ForceMode2D.Impulse);
      int shotRotDeg = 180;
      int aniH = (int)Math.Round(animator.GetFloat("Horizontal"));
      int aniV = (int)Math.Round(animator.GetFloat("Vertical"));

      //Debug.Log(aniH);
      //Debug.Log(aniV);

      Vector3 newvec;

      // upright   1, -1
      if (aniH == 1 && aniV == 0){
        shotRotDeg = 225;
        newvec  = new Vector3(1,(float)0.5,0);
        //Debug.Log("upright");

      }

      // downleft        1, 1
      else if (aniH == -1 && aniV == 0)
      {
        shotRotDeg = 315;
        newvec  = new Vector3(-1,(float)(-0.5),0);
        //Debug.Log("downleft");
      }

      // UpLeft        -1, 1
      else if (aniH == 0 && aniV == 1)
      {
        shotRotDeg = 45;
        newvec  = new Vector3(-1,(float)0.5,0);
        //Debug.Log("upleft");
      }

      // Downright    -1, -1
      else
      {
        shotRotDeg = 135;
        newvec  = new Vector3(1,(float)(-0.5),0);
        //Debug.Log("downright");

      }
      //newvec  = new Vector3(1,(float)0.5,0);
      GameObject pancake = Instantiate(pancakePrefab,firePoint.position+1*(newvec.normalized),player.transform.rotation);
      Rigidbody2D rb = pancake.GetComponent<Rigidbody2D>();
      Rigidbody2D plrb = player.GetComponent<Rigidbody2D>();
      //Debug.Log(newvec*bulletForce);
      pancake.transform.Rotate(0, 0, shotRotDeg);
      rb.AddForce(newvec*bulletForce,ForceMode2D.Impulse);

    }

}
