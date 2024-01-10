using UnityEngine;
using UnityEngine.UI;

public class WeaponSwing : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
    }

    public void Swing()
    {
        instance.start();
    }

    public void SetSize(float parameter)
    {
        instance.setParameterByName("WeaponSize",parameter);
    }

}
