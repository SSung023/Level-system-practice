using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{

    [SerializeField] private bool unlocked; // Default value == false

    public Image unlockImage;
    public GameObject[] stars;


    private void UpdateLevelImage()
    {
        if (!unlocked) //MARKER if unclock is false means This level is clocked!
        {
            
        }
    }

}
