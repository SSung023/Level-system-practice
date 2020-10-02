using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{

    [SerializeField] private bool unlocked; // Default value == false

    public Image unlockImage;
    public GameObject[] stars;


    
    private void Update()
    {
        UpdateLevelImage(); // TODO Move this method later
    }
    
    private void UpdateLevelImage()
    {
        if (!unlocked) //MARKER if unclock is false means This level is clocked!
        {
            unlockImage.gameObject.SetActive(true); //만약 unlock 이라면 unlockImage(자물쇠)를 활성화
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(false); // stars가 밑에 뜨지 않게 비활성화
            }

        }
        else //if unlock is true means This level can play!
        {
            unlockImage.gameObject.SetActive(false); //만약 unlock 이라면 unlockImage(자물쇠)를 비활성화
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true); //stars가 밑에 뜨도록 활성화
            }
        }
    }

    public void PressSelection(string _LevelName) //when we press this level, we can move to the corresponding Scene to play
    {
        if (unlocked)
        {
            SceneManager.LoadScene(_LevelName);
        }
    }
    
    

}
