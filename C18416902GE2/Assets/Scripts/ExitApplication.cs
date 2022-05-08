using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Exit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Exit()
    {
        yield return new WaitForSeconds(15);
        StartCoroutine(Transition());

    }

    IEnumerator Transition()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        Application.Quit();
    }
}
