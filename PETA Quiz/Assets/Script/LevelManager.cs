using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButton;
    // Start is called before the first frame update
    void Start()
    {
        int unlockedLevel = PlayerPrefs.GetInt("levelDone", 1);

        for (int i = 0; i < levelButton.Length; i++)
        {
            if(i + 1 > unlockedLevel)
            {
                levelButton[i].interactable = false;
            }
        }
    }

    public void SelectLevel(int level)
    {
        SceneManager.LoadScene("Game" + level);
    }
}
