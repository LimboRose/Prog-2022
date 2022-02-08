using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroy : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {

        Debug.Log("Started Coroutine" + Time.time);


        yield return new WaitForSeconds(5);

        Destroy(gameObject);

    }

}
