using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour {

    public GameObject box;
    public Transform move;
    public Transform move2;
    public float speed;

    private Animator myAnim;
    private bool buttonOn;

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        buttonOn = true;
        box.transform.position = Vector2.Lerp(box.transform.position, move.position, Time.deltaTime * speed);
        myAnim.SetBool("On", buttonOn);

    }

    void OnTriggerExit2D(Collider2D other)
    {
        buttonOn = false;
        box.transform.position = Vector2.Lerp(box.transform.position, move2.position, Time.deltaTime * speed);

        myAnim.SetBool("On", buttonOn);
    }
}
