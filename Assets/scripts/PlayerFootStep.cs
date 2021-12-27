using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootStep : MonoBehaviour
{
    AudioSource animSound;
    // Start is called before the first frame update
    void Start()
    {
        animSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerStepSound()
    {
        animSound.Play();
    }
}
