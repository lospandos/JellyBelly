using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{

    private Camera cam;
    private Rigidbody rib;

    public float lerpValue;
    public float minY, maxY;
    public float minX, maxX;
    public float speed;

    public Rigidbody rgbdy;

    private bool isGameEnded = false;

    void Start()
    {
        cam = Camera.main;
        
    }

    
    void Update()
    {
        if (!isGameEnded)
        {
            rgbdy.velocity = Vector3.forward * speed * Time.deltaTime;
          //  rib.velocity = Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetButton("Fire1"))
        {
            ChangeScale();
        }

    }
     public void ChangeScale()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 moveVec = cam.ScreenToWorldPoint(mousePos);

        float x = transform.localScale.x;
        moveVec.z = transform.localScale.z;
       // moveVec.y *= 2f;
        moveVec.y = Mathf.Clamp(moveVec.y,minY,maxY);

        x = maxY / moveVec.y;

        Debug.Log("x:"+x);
        moveVec.x = Mathf.Clamp(x,minX,maxX);

        transform.localScale = moveVec;


        Ghostjelly.instance.ChangeScaleOfTheGhost(moveVec);


    }


}
