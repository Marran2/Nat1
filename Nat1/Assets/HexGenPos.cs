using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGenPos : MonoBehaviour {

    public Camera camera;
    // Update is called once per frame
    void Update()
    {
        Vector3 temp = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 30, Input.mousePosition.z));

        Debug.DrawLine(this.transform.position, temp, Color.white);
    }
}
