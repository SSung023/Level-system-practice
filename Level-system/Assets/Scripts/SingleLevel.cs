using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleLevel : MonoBehaviour
{
    private int currentStarsNum = 0;
    public int levelIndex;
    
    public void BackButton()
    {
        SceneManager.LoadScene("00_Level Selection");
    }

    public void PressStarButton(int _starNum)
    {
        currentStarsNum = _starNum;
        
        //lower reward will not be saved
        if (currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, _starNum);
        }
        
        //BackButton();
        
        //MARKER Each level has saved thier own stars number
        //CORE PlayerPrefs.getInt("KEY", "VALUE"); we can use the KEY to find our VALUE
        Debug.Log(PlayerPrefs.GetInt("Lv" + levelIndex, _starNum));
        
        BackButton();
    }
    
}
