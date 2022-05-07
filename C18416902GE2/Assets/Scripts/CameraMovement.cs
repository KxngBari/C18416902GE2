using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeedY = 0.035f;
    public float cameraSpeedZ = -1f;
    bool constantMove = true;
    public int check;
    public Transform targetShip;
    float degrees = 210;
    Vector3 to;

    void Start()
    {
        to = new Vector3(0, degrees, 0);
        StartCoroutine(MoveCamera());
    }

    // Update is called once per frame
    void Update()
    {
        if (constantMove)
        {
            transform.Rotate(0, cameraSpeedY, cameraSpeedZ * Time.deltaTime);
        }
        if (!constantMove)
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime * 0.30f);
            //transform.Rotate(0, -0.25f, cameraSpeedZ * Time.deltaTime);
        }
    }

    IEnumerator MoveCamera()
    {
        yield return new WaitForSeconds(4.5f);
        transform.localEulerAngles = new Vector3(0, -50, 0);
        transform.position = new Vector3(-5.1f, 1, -173.4f);
        constantMove = false;
    }
}
