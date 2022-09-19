using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject _optionPanel;
    public GameObject _mainMenu;
    public GameObject
        evaluasiPanel,
        caraMainPanel,
        tentangPanel,
        tentangPanel2,
        tentangPanel3,
        tentangPanel4,
        namaPanel;

    public InputField usernameInput;
    public static string username;
    public Text nameText;

    public GameObject
        hintPanel;


    public static int Level;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Options()
    {
        _optionPanel.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void Evaluasi()
    {
        evaluasiPanel.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void Nama()
    {
        namaPanel.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void Tentang()
    {
        tentangPanel.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void Tentang2()
    {
        tentangPanel.SetActive(false);
        tentangPanel2.SetActive(true);
    }

    public void Tentang3()
    {
        tentangPanel2.SetActive(false);
        tentangPanel3.SetActive(true);
    }

    public void Tentang4()
    {
        tentangPanel3.SetActive(false);
        tentangPanel4.SetActive(true);
    }

    public void CaraMain()
    {
        caraMainPanel.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void MainMenu()
    {
        evaluasiPanel.SetActive(false);
        caraMainPanel.SetActive(false);
        tentangPanel.SetActive(false);
        tentangPanel2.SetActive(false);
        tentangPanel3.SetActive(false);
        tentangPanel4.SetActive(false);
        _optionPanel.SetActive(false);
        _mainMenu.SetActive(true);
    }

    public void goMap()
    {
        SceneManager.LoadScene("MapScreen");
    }

    public void goGame(int level)
    {
        Level = level;
        Debug.Log("level = " + Level.ToString());
        SceneManager.LoadScene("Game"+level);
        
    }

  
    public void goMateri(int level)
    {
        Level = level;
        Debug.Log("Materi = " + Level.ToString());
        SceneManager.LoadScene("Materi" + level);

    }
   

    public void goMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Hint()
    {
        hintPanel.SetActive(true);
    }

    public void SaveUsername()
    {
        nameText.text = usernameInput.text;
    }

    public void ExtraWaktu()
    {
        Debug.Log("extra waktu");
    }

   
}
