using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoveGate : MonoBehaviour {

    public GameObject gate;

    private Animator myAnim;
    private bool buttonOn;

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        buttonOn = true;
        gate.gameObject.SetActive(false);
        myAnim.SetBool("On", buttonOn);

    }

    void OnTriggerExit2D(Collider2D other)
    {
        buttonOn = false;
        gate.gameObject.SetActive(true);
        myAnim.SetBool("On", buttonOn);
    }
}

