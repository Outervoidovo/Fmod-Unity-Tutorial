using UnityEngine;

public class EventPlayer_2 : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;

    void Start() 
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
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
