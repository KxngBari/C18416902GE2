using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public GameObject enemyShips;

    // Start is called before the first frame update
    void Start()
    {
        camera2.enabled = false;
        camera3.enabled = false;
        StartCoroutine(EnableCamera2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnableCamera2()
    {
        yield return new WaitForSeconds(9.75f);
        camera1.enabled = false;
        camera2.enabled = true;
        StartCoroutine(EnableCamera3());
    }

    IEnumerator EnableCamera3()
    {
        yield return new WaitForSeconds(5);
        camera2.enabled = false;
        camera3.enabled = true;
        enemyShips.SetActive(true);
    }
}
