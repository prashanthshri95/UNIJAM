using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject new_house;
    public Transform currentHouse;
    public GameObject targetUD;
    public GameObject targetLR;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(8, 10);
    }

    // Update is called once per frame
    void Update()
    {
      Physics2D.IgnoreLayerCollision(8, 9);
      Physics2D.IgnoreLayerCollision(8, 10);

    }

    void OnCollisionEnter2D(Collision2D col)
    {

      Physics2D.IgnoreLayerCollision(8, 9);
      Physics2D.IgnoreLayerCollision(8, 10);
          if ((col.gameObject.name).Equals("HouseLR") || (col.gameObject.name).Equals("HouseUD") )
        {
            Debug.Log("triggered" + col.gameObject.name + " : " + gameObject.name + " : ");
            // KeepScore.Score += 100;
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);

            //Debug.Log("your score is" + KeepScore.Score);
            //Destroy(this.gameObject);


            currentHouse = GetComponent<Transform>();
            // Instantiate(new_house, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(col.gameObject);
            GameObject house = Instantiate(new_house, col.gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);

           // GameObject go3 = new GameObject("new_house", typeof(Rigidbody), typeof(BoxCollider));
          }
        /*
        void OnCollisionEnter(Collision collison)
        {
            if (collison.transform.name == "FPSController")
            {
                KeepScore.Score += 100;
                Debug.Log("Hit the house");
                Destroy(gameObject);
            }
        }
        */
    }
}
