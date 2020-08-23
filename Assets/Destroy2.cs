using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
      Destroy(this.gameObject);
    }
}
