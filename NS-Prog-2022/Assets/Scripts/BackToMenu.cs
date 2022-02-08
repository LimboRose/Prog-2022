using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{

    void Start()
    {
        
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        
        Debug.Log("Started Coroutine" + Time.time);

        
        yield return new WaitForSeconds(2);


        SceneManager.LoadScene(0);
    }


}
