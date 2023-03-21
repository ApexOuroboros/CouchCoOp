using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class P2Move : MonoBehaviour
{
    CharacterController p2Con;

    public float speed = 6.0f;
    public float jSpeed = 8.0f;
    public float grav = 20.0f;
    public Vector3 mDir2 = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        p2Con = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (p2Con.isGrounded)
        {
            mDir2 = new Vector3(Input.GetAxis("Vertical2"),0 ,0);
            mDir2 *= speed;


            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(0, -1, 0);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(0, 1, 0);

            if (Input.GetKey(KeyCode.Keypad0))
            {
                mDir2.y = jSpeed;
            }
        }
        mDir2.y -= grav * Time.deltaTime;
        p2Con.Move(mDir2 * Time.deltaTime);
    }
}
