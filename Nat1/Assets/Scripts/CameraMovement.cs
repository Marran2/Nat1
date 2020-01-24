using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float smoothSpeed = 0.125f;
    public float scrollSpeed = 50f;
    public float edgeSensitivity = 0.05f;

    void Update() {
        if (Input.mousePosition.y >= Screen.height * (1f - edgeSensitivity) || Input.GetKey("up")) {
            transform.Translate(Vector3.forward * Time.deltaTime * scrollSpeed * 2, Space.World);
        }

        if (Input.mousePosition.y <= Screen.height * edgeSensitivity || Input.GetKey("down")) {
            transform.Translate(Vector3.back * Time.deltaTime * scrollSpeed * 2, Space.World);
        }

        if (Input.mousePosition.x >= Screen.width * (1f - edgeSensitivity) || Input.GetKey("right")) {
            transform.Translate(Vector3.right * Time.deltaTime * scrollSpeed * 2, Space.World);
        }

        if (Input.mousePosition.x <= Screen.height * edgeSensitivity || Input.GetKey("left")) {
            transform.Translate(Vector3.left * Time.deltaTime * scrollSpeed * 2, Space.World);
        }


    }

}
