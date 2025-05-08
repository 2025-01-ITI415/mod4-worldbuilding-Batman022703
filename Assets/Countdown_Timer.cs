using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Timer : MonoBehaviour
{

private float endgametime; 
public float numberofminutes= 7f; 
private Text timertext;


    // Start is called before the first frame update
    void Start()
    {
     endgametime = Time.time + (numberofminutes*60); 
     timertext= GetComponent< Text> (); 
    }

    // Update is called once per frame
    void Update()
    {
     timertext.text = (endgametime - Time.time).ToString("#.00");    
    }
}
