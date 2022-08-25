using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostjelly : MonoBehaviour
{
    public static Ghostjelly instance;
    public Transform[] ghostposes;

    private int index = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    


    public void ChangeScaleOfTheGhost(Vector3 scale)
    {
        scale.y *= 1.5f;
        transform.localScale = scale;
    }



    public void ChangePosOfTheGhost()
    {
        index++;
        if(ghostposes.Length>index)
        {
            transform.position = ghostposes[index].transform.position;
        }
    }


}
