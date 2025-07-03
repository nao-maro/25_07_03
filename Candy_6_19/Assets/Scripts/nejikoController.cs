using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nejikoController : MonoBehaviour
{
    // Start is called before the first frame update
    
    //1.プレイヤーのキー入力を受け取る
    //2.キー入力の方向にあわせて移動する
    //3.移動方向にあわせてアニメーションを再生する
    
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
