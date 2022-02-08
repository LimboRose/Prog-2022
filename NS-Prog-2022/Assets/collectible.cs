using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    
    public GameHandler GH;
    public AudioClip soulSound;

    private void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
        
    }


    private void OnTriggerEnter(Collider other)
    {
        GH.souls++;
        AudioSource.PlayClipAtPoint(soulSound, transform.position,1f);
        Destroy(gameObject);
        
    }
}
