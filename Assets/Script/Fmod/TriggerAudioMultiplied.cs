using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudioMultiplied : MonoBehaviour
{
    public FMODUnity.EventReference Event1;
    public FMODUnity.EventReference Event2;
    public FMODUnity.EventReference Event3;
    public FMODUnity.EventReference Event4;
    public FMODUnity.EventReference Event5;
    
    public void PlayOneShot1()
    {
        //FMODUnity.RuntimeManager.PlayOneShot(Event1,transform.position);
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event1,gameObject);
    }

    public void PlayOneShot2()
    {
        //FMODUnity.RuntimeManager.PlayOneShot(Event2,transform.position);
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event2,gameObject);
    }

    public void PlayOneShot3()
    {
        //FMODUnity.RuntimeManager.PlayOneShot(Event3,transform.position);
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event3,gameObject);
    }

    public void PlayOneShot4()
    {
        //FMODUnity.RuntimeManager.PlayOneShot(Event4,transform.position);
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event4,gameObject);
    }

    public void PlayOneShot5()
    {
        //FMODUnity.RuntimeManager.PlayOneShot(Event5,transform.position);
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event5,gameObject);
    }

}
