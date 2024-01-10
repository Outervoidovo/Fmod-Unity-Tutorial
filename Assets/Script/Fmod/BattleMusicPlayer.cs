using UnityEngine;
using UnityEngine.UI;

public class BattleMusicPlayer : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;
    public FMODUnity.EventReference Event;

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(Event);
        instance.start();
    }

    public void SetFight(bool state)
    {
        if(state == true)
        {
            instance.setParameterByName("OnFight",1);
        }
        else
        {
            instance.setParameterByName("OnFight",0);
        }
    }
    
}
