using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nejikoController : MonoBehaviour
{
    // Start is called before the first frame update
    
    //1.�v���C���[�̃L�[���͂��󂯎��
    //2.�L�[���͂̕����ɂ��킹�Ĉړ�����
    //3.�ړ������ɂ��킹�ăA�j���[�V�������Đ�����
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Test");
        }
    }
}
