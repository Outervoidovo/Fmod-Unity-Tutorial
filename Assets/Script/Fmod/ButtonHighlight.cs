using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHighlight : MonoBehaviour , IPointerEnterHandler
{
    public FMODUnity.EventReference Event;

    public void OnPointerEnter(PointerEventData eventData)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached(Event,gameObject);
        
        //仅在可交互按钮上触发声音
        
        /*
        Button button = GetComponent<Button>();
        if (button.interactable)
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached(Event,gameObject);
        }
        */
    }
}
