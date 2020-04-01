using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SnapshotCamera snapCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            snapCam.CallTakeSnapshot();
        }
    }
}
