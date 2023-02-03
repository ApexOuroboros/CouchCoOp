using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof(CharacterController))]

public class P1Move : MonoBehaviour
{
    CharacterController p1Con;

    //Rigidbody p1R;

    public float speed = 6.0f;
    public float jSpeed = 8.0f;
    public float grav = 20.0f;
    public Vector3 mDir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        p1Con = GetComponent<CharacterController> ();   

        //p1R = GetComponent<Rigidbody> ();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(p1Con.isGrounded)
        {
            //mDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //mDir *= speed;


            if (Input.GetKey(KeyCode.A))
                transform.Rotate(0, -1, 0);

            if (Input.GetKey(KeyCode.D))
                transform.Rotate(0, 1, 0);

            if (Input.GetKey(KeyCode.W))
                transform.position +=  Vector3.forward * Time.deltaTime;

            if (Input.GetKey(KeyCode.S))
                transform.position += Vector3.back * Time.deltaTime;

            if (Input.GetButton("Jump"))
            {
                mDir.y = jSpeed;
            }
        }
        mDir.y -= grav * Time.deltaTime;
        p1Con.Move(mDir * Time.deltaTime);

    }
}
