using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
     [SerializeField] float speed = 9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
// //GetComponent<Transform>()


        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed*Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(speed*Time.deltaTime,0,0);
        }

//         if(Input.GetKey(KeyCode.W)){
//             transform.position += new Vector3(0,speed*Time.deltaTime,0);
//         }

//         if(Input.GetKey(KeyCode.S)){
//             transform.position -= new Vector3(0,speed*Time.deltaTime,0);
//         }

//         if(Input.GetKeyDown(KeyCode.Q)){ //meepis stealth mode
//             //GetComponent<SpriteRenderer>().color = Color.black;
//             transform.localScale *= 1 + (.5f * Time.deltaTime);
//         }
//     }
    }
}
