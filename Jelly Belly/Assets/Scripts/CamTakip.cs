using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTakip : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float lerpValue;

    private void LateUpdate()
    {
        Vector3 despos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position,despos,lerpValue);
    }






}
