using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text starsText;

    private void Update()
    {
        UpdateStarsUI(); // TODO move this method later
    }

    private void UpdateStarsUI()
    {
        int sum = 0;

        //13 -> number of stage
        for (int i = 0; i < 13; i++)
        {
            //모든 레벨의 star의 갯수를 더한다
            sum += PlayerPrefs.GetInt("Lv" + i.ToString());
        }

        starsText.text = sum + "/" + 39;
    }

}
