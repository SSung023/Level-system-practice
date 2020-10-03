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

    public Sprite starSprite;


    private void Start()
    {
        PlayerPrefs.DeleteAll();
    }
    
    private void Update()
    {
        UpdateLevelImage(); // TODO Move this method later
        UpdateLevelStatus(); // TODO Move this method later
    }

    private void UpdateLevelStatus()
    {
        // if current Lv is 5, the pre should be 4
        int previousLevelNum = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("Lv" + previousLevelNum.ToString()) > 0)
        {
            unlocked = true;
        }

        for (int i = 0; i < PlayerPrefs.GetInt("Lv" + gameObject.name); i++)
        {
            stars[i].gameObject.GetComponent<Image>().sprite = starSprite;
        }
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
