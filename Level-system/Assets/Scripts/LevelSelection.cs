using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private bool isUnlocked; //Default 값 == false

    public Image unlockImage;
    public GameObject[] stars;



    private void Update()
    {
        UpdateLevelImage();
    }
    
    private void UpdateLevelImage()
    {
        //만일 isUnlocked 비활성화라면 자물쇠 이미지 Set true
        if (!isUnlocked)
        {
            unlockImage.gameObject.SetActive(true);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].SetActive(false);
            }
        }
        
        // level이 unlock됐다면 이미지 change
        else
        {
            unlockImage.gameObject.SetActive(false);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].SetActive(true);
            }
        }
    }


    public void PressSelection(string _LevelName) //버튼을 눌렀을 때, 해당 Scene으로 이동하게 하는 Method
    {
        if (isUnlocked)
        {
            SceneManager.LoadScene(_LevelName);
        }
    }
    
    


}
