using UnityEngine;
using UnityEngine.UI;

public class SliderControlBus : MonoBehaviour
{
    /*
    脚本已优化调整。
    Slider组件输出的数据类型是float，可直接关联至目标参数，无需额外声明
    */
    public string BusName;
    private FMOD.Studio.Bus bus;

    void Start() 
    {
        bus = FMODUnity.RuntimeManager.GetBus("bus:/" + BusName);
    }

    public void SetBusVolume(float busvolume)
    {
        bus.setVolume(busvolume);
    }
}