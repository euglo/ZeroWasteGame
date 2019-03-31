using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text liveText;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameManager.lives);

        /*
        switch(GameManager.lives)
        {
            case 4:
                liveText.text = "Lives: 3";
                break;
            case 2:
                liveText.text = "Lives: 2";
                break;
            case 0:
                liveText.text = "Lives: 1";
                break;
            default:
                liveText.text = "Lives: 0";
                break;
        }
        */

        liveText.text = "Health: " + GameManager.lives.ToString();


    }
}
