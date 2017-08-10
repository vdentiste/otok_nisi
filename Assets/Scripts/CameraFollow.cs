using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets._2D;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothTime = 0.5f;
    public bool useOffset = true;

    Vector3 offset = Vector3.zero;
    PlatformerCharacter2D player;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
        player = target.gameObject.GetComponent<PlatformerCharacter2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempPos = transform.position;

        if (useOffset)
        {
            if (player.m_FacingRight)
            {
                tempPos = transform.position - offset;
            }
            else
            {
                tempPos = transform.position + offset;
            }
        }

        float xVelocity = 0f;

        //if (transform.position.x < target.position.x) {
        //tempPos.x = target.position.x;
        tempPos.x = Mathf.SmoothDamp(tempPos.x, target.position.x, ref xVelocity, smoothTime);
        //}

        if (useOffset)
        {
            if (player.m_FacingRight)
            {
                transform.position = tempPos + offset;
            }
            else
            {
                transform.position = tempPos - offset;
            }
        }
        else
        {
            transform.position = tempPos;
        }
    }
}
