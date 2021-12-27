using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disappear : MonoBehaviour
{
    public gamemngrObj game;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            game.AddScore();
            
        }
    }
    

}
