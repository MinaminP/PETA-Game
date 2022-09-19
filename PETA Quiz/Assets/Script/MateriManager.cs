using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class MateriManager : MonoBehaviour
{

    public Text textJudulMateri;
    public Text textIsiMateri;
    public GameObject characterAnim;
    private Animator charAnim;
    public GameObject character;
    public GameObject nextButton;
    public GameObject startButton;
    public Materi materi;
    public float textSpeed;
    public GameObject video;
    public VideoPlayer videoPlayer;

    private Queue<string> isiMateri;

    public bool withVideo;
    public bool isPlay;

    // Start is called before the first frame update
    void Start()
    {
        isiMateri = new Queue<string>();
        charAnim = characterAnim.GetComponent<Animator>();

        StartMateri(materi);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isPlay)
        {
            charAnim.SetBool("isMenjelaskan", true);
        }

        if (!isPlay)
        {
            charAnim.SetBool("isMenjelaskan", false);
        }
    }

    public void StartMateri(Materi materi)
    {
        textJudulMateri.text = materi.judulMateri;

        isiMateri.Clear();

        foreach (string mat in materi.isiMateri)
        {
            isiMateri.Enqueue(mat);
        }

        
        DisplayNextMateri();
    }

    public void DisplayNextMateri()
    {
        if(isiMateri.Count == 0)
        {
            EndMateri();
            return;
        }

        string materi = isiMateri.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeMateri(materi));
    }

    IEnumerator TypeMateri (string mat)
    {
        textIsiMateri.text = "";
        foreach (char letter in mat.ToCharArray())
        {
            isPlay = true;
            textIsiMateri.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void EndMateri()
    {
        startButton.SetActive(true);
        if(withVideo == true)
        {
            character.SetActive(false);
            video.SetActive(true);
            videoPlayer.Play();
        }
        nextButton.SetActive(false);
    }
}
