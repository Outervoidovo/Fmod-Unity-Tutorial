using UnityEngine;

public class CubeTrigger2 : MonoBehaviour
{
    private float dist , distance;
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;
    public GameObject cubeObject;
    public GameObject triggerPlane;

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
    }
    
    void Update()
    {
        dist = cubeObject.transform.localPosition.y - triggerPlane.transform.localPosition.y;
        
        if (dist <= 25)
        {
            distance = dist - 5;
            if (dist < 0)
            {
                distance = 0;
            }
        }
        else
        {
            distance = 20;
        }
        
        distance = dist - 5;

        //print("Distance = " + distance);

        instance.setParameterByName("Distance",distance);
    }

    void OnTriggerEnter(Collider other)
    {
        instance.start();
    }

    void OnTriggerExit(Collider other) 
    {
        instance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
    
}