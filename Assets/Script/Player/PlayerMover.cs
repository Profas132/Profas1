using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    { 
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        rb.AddForce(movement * moveSpeed * 200);
        
        bool isRuning = true;
        //Debug.Log(horizontal);
        if (horizontal > 0)
        {
            FlipPerson(0);
            isRuning = true;
        }
        else if (horizontal < 0)
        {
            FlipPerson(-180);
            isRuning = true;
        } else if (horizontal == 0) isRuning = false;

        anim.SetBool ("isRuning", isRuning);
        anim.SetFloat("vertical", vertical);
    }

    private void FlipPerson(int y)
    {
        transform.eulerAngles = new Vector3(0, y, 0);
    }
}
