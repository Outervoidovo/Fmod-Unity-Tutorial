using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    //private float distance;
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;
    //public GameObject Object;
    
    void Start()
    {
        //Object.transform.Find("CubeObject");
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
    }
/*
    void Update()
    { 
        if (Object.transform.localPosition.y <= 20)
        {
            distance = Object.transform.localPosition.y;
        }
        else
        {
            distance = 20;
        }

        instance.setParameterByName("Distance",distance);
    }
*/
    void OnTriggerEnter(Collider other)
    {
        PlayInstance();
    }

    void PlayInstance()
    {
        instance.start();
    }
    

    /*
    void Update()
    {
        instance.setParameterByName("Distance",distance);
    }
    */
}
