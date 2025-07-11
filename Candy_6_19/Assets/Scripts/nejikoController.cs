using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nejikoController : MonoBehaviour

   
{
    // Start is called before the first frame update



    CharacterController controller;
    Vector3 moveDirection = Vector3.zero;
    public float speed = 0f;
    Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") > 0.0f)
        {
            moveDirection.z = Input.GetAxis("Vertical") * speed;
        }
        else
        {
            moveDirection.z = 0.0f;
        }

        //Horisontal(左右入力)があれば、ねじこを回転させる
        transform.Rotate(0, Input.GetAxis("Horizontal") * 3f, 0);
        
        //Jumpキーの入力があればy軸に力をかける
        if (Input.GetButton("Jump"))
        {
            moveDirection.y = 10f;
            animator.SetTrigger("jump");
        }
        
        //移動量をTransfomeに変換する
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        //Controllerに移動量を渡す
        controller.Move(globalDirection);

        animator.SetBool("run", moveDirection.z > 0f);
    }
}
