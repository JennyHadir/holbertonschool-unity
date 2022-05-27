using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 cameraOffset;

    public Transform player;

    public float sensitivity = 0.5f;

    public bool isInverted;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("inverted") == 1)
        {
            cameraOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * Quaternion.AngleAxis((Input.GetAxis("Mouse Y") * -1)* sensitivity, Vector3.left) * cameraOffset;
            transform.position = player.position + cameraOffset;

            transform.LookAt(player.position);
        }
        else
        {
            cameraOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensitivity, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * sensitivity, Vector3.left) * cameraOffset;
            transform.position = player.position + cameraOffset;

            transform.LookAt(player.position);
        }
    }


}
