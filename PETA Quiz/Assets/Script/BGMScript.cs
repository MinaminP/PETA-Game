using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour
{
    public static BGMScript BgmInstance;
    public AudioSource audioSrc;

    private void Awake()
    {
        if(BgmInstance != null && BgmInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        BgmInstance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
}
