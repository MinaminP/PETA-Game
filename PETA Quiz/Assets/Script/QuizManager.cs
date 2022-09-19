using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public int jumlahSoal;
    public Text _jumlahBenar;
    public int jumlahBenar;
    public int jumlahSalah;
    public GameObject QuizPanel;
    public GameObject SeleaiPanel;
    public TMP_Text QuestionText;
    public Text SoalNumber;
    public int Number;
    public static float mainTimer;
    public float setTimer;
    public Text timerText;
    public int nextLevel;
    public int thisLevel;

    // Start is called before the first frame update
    private void Start()
    {
        PlayerPrefs.SetInt("benar" + thisLevel, 0);
        jumlahSoal = QnA.Count;
        generateQuestion();
        Number = 1;
        mainTimer = setTimer;
    }

    // Update is called once per frame
    void Update()
    {
        ///////Timer
        float minutes = Mathf.FloorToInt(mainTimer / 60);
        float seconds = Mathf.FloorToInt(mainTimer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (mainTimer > 0)
        {
            mainTimer -= Time.deltaTime;
        }
        else
        {
            mainTimer = 0;
            PlayerPrefs.SetInt("levelDone", nextLevel);
            QuizPanel.SetActive(false);
            SeleaiPanel.SetActive(true);
        }


        if(mainTimer <= 0)
        {
            //do something
        }
        ///////////////////////////

        _jumlahBenar.text = jumlahBenar.ToString() + " / " + jumlahSoal.ToString();
        SoalNumber.text = "SOAL " + Number.ToString();
        
    }



    public void Next()
    {
        QnA.RemoveAt(currentQuestion);
        Number += 1;
        generateQuestion();
    }

    public void benar()
    {
        jumlahBenar += 1;
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }


    void generateQuestion()
    {

        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

           QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
       
        if(QnA.Count <= 0)
        {
            QuizPanel.SetActive(false);
            SeleaiPanel.SetActive(true);

            /*PlayerPrefs.SetInt("benar" + thisLevel, jumlahBenar);

            int benar = PlayerPrefs.GetInt("benar" + thisLevel);
            Debug.Log("Jumlah benar : " + benar);

            jumlahSalah = jumlahSoal - jumlahBenar;
            PlayerPrefs.SetInt("salah" + thisLevel, jumlahSalah);
            Debug.Log("Jumlah salah : " + jumlahSalah);*/

            if (jumlahBenar > 4)
            {
                PlayerPrefs.SetInt("levelDone", nextLevel);
            }
            Debug.Log("SoalHabis");

        }

    }
}
