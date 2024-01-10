using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public FMODUnity.EventReference Event;
    public bool PlayOnAwake;
    
    public void PlayOneShot()
    {
        //FMODUnity.RuntimeManager.PlayOneShot(Event,transform.position);
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event,gameObject);
    }

    private void Start() 
    {
        if (PlayOnAwake)
            PlayOneShot();
    }
}
