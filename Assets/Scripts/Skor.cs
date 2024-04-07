using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    Text text;
    public static int trashcount = 0;

    void Start()
    {
        text = GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        text.text = "Puan: "+trashcount.ToString();
    }
}
