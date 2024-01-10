using UnityEngine;
using UnityEngine.UI;

public class ToggleControlVca : MonoBehaviour
{
    /*
    脚本已优化调整。
    Toggle组件输出的数据类型是bool，可直接关联至目标参数，无需额外声明
    同时也解决了先前遇到的该脚本需与Toggle加载于相同GameObject中才能够
    正常运行的问题
    */
    public string VcaName;
    private FMOD.Studio.VCA vca;

    void Start()
    {
        vca = FMODUnity.RuntimeManager.GetVCA("vca:/" + VcaName);
    }

    public void SetVca(bool state)
    {
        if(state == true)
        {
            vca.setVolume(1);
        }
        else
        {
            vca.setVolume(0);
        }
    }
}