using UnityEngine;

public class ObjectFallImpact : MonoBehaviour
{
    private float height;
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;

    void Start()
    {
        print("Height = " + transform.localPosition.y);
        height = transform.localPosition.y;
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
    } 
    
    void OnCollisionEnter(Collision other)
    {
        PlayInstance();
    }

    public void PlayInstance()
    {
        instance.setParameterByName("Height",height);
        instance.start();
    }
}
