using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yonetici : MonoBehaviour
{

    public bool oyundurdumu = false;
    public void oyunudurdur()
    {
        if(oyundurdumu == false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
            Debug.Log("Pause Başarılı");
        }

        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
    }
}
