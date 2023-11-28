using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] protected float speed = 1;
    [SerializeField] AnimationStateChanger animationStateChanger;
    //[SerializeField] float speed = 1;
    Rigidbody2D rb;

    void Awake(){
         rb = GetComponent<Rigidbody2D>();
    }

    void Start(){

    }

    public void MoveTransform(Vector3 vel){
        transform.position += vel * speed * Time.deltaTime;
    }

    public void MoveRB(Vector3 vel){
        rb.velocity = vel * speed;
        if(vel.magnitude > 0){
            animationStateChanger.ChangeAnimationState("Walk");
        }else{
            animationStateChanger.ChangeAnimationState("Idle");
        }
        //rb.MovePosition(transform.position + (vel*Time.fixedDeltaTime));
        //rb.AddForce(vel);
    }

    // public void StepMove(Vector3 direction){
    //     transform.position += direction;
    // }
}
