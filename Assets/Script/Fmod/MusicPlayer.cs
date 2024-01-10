using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;

    void Start() 
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
        instance.start();   
    }

    void OnEnable()
    {
        instance.start();
    }

    void OnDisable()
    {
        instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        //instance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}