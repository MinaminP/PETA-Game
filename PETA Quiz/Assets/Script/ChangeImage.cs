using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    [SerializeField]
    private Sprite[] switchSprites;

    public int counter;
    public Image switchImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSprite()
    {
        counter++;
        switchImage.sprite = switchSprites[counter];
    }
}
