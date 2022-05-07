using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShip : MonoBehaviour
{
    public Transform ship;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(4, 4, -6);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ship.position + offset;
    }
}
