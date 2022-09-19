using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript : MonoBehaviour
{
    public Button bgmOn, bgmOff;
    // Start is called before the first frame update
    void Start()
    {
        if (BGMScript.BgmInstance.audioSrc.isPlaying)
        {
            bgmOn.interactable = false;
        } else
        {
            bgmOff.interactable = false;
        }
    }

    public void BgmOn()
    {
        BGMScript.BgmInstance.audioSrc.Play();
        bgmOn.interactable = false;
        bgmOff.interactable = true;
    }

    public void BgmOff()
    {
        BGMScript.BgmInstance.audioSrc.Stop();
        bgmOff.interactable = false;
        bgmOn.interactable = true;
    }
}
