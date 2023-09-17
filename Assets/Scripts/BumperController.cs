using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider  bola;
    public float multiplier;
    public Color color;

    private Animator animator;
    private Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();
        animator = GetComponent<Animator>();    

        render.material.color = color;
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animasiin
            animator.SetTrigger("hit");
        }
    }
}
