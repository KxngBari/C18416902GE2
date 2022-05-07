using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2CameraManager : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public GameObject friendlyShips;
    void Start()
    {
        camera2.enabled = false;
        StartCoroutine(EnableCamera2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnableCamera2()
    {
        yield return new WaitForSeconds(4.5f);
        camera1.enabled = false;
        camera2.enabled = true;
        friendlyShips.SetActive(true);
    }
}
