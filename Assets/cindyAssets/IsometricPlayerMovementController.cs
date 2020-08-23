using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsometricPlayerMovementController : MonoBehaviour
{
    Vector2 movement;
    public float movementSpeed = 1f;
    //IsometricCharacterRenderer isoRenderer;


    public Animator animator;

    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        //isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 inputVector;

        if (horizontalInput!=0 && verticalInput!=0) {
           inputVector = new Vector2(horizontalInput, verticalInput);
        }
        if (horizontalInput==0) {
           inputVector = new Vector2(-(verticalInput), verticalInput/2);
        }
        else {
           inputVector = new Vector2(horizontalInput, horizontalInput/2);
        }

        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        //isoRenderer.SetDirection(movement);
        rbody.MovePosition(newPos);


        //animato
        //aniamtor
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement != Vector2.zero)
           {
                animator.SetFloat("Horizontal", movement.x);
                animator.SetFloat("Vertical", movement.y);
            }

            animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void OnCollisionEnter2D(Collision2D col) {
          Debug.Log("OnCollisionEnter2D");
          if(col.gameObject.name == "Bear" || col.gameObject.name == "Bear1" ||col.gameObject.name == "Bear2" ||col.gameObject.name == "NPC"){
                Destroy(this.gameObject);
                SceneManager.LoadScene (sceneName:"Start");
          }
    }
}
