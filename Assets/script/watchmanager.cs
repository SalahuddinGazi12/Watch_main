using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchmanager : MonoBehaviour
{
    public GameObject wtachmodel1;
    public GameObject wtachmodel2;
    public GameObject wtachmodel3;
    public GameObject windowswtachmodel1;
    public GameObject windowswtachmodel2;
    public GameObject windowswtachmodel3;


    Animation w1windowanimation;
    Animation w2windowanimation;
    Animation w3windowanimation;
    void Start()
    {
        w1windowanimation = windowswtachmodel1.GetComponent<Animation>();
        w2windowanimation = windowswtachmodel2.GetComponent<Animation>();
        w3windowanimation = windowswtachmodel3.GetComponent<Animation>();
    }

    


    public void watch1()
    {
  
        w1windowanimation["w1animation"].speed = 1;
        w1windowanimation.Play();
    }
    public void watch2()
    {
        w2windowanimation["w2animation"].speed = 1;
        w2windowanimation.Play();
    }
    public void watch3()
    {
        w3windowanimation["w3animation"].speed = 1;
        w3windowanimation.Play();
    }
    public void closedbutton()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;
        if (buttonname == "w1close")
        {
            w1windowanimation["w1animation"].speed = -1;
            w1windowanimation["w1animation"].time = w1windowanimation["w1animation"].length;
            w1windowanimation.Play();
        }
        else if (buttonname == "w2close")
        {
            w2windowanimation["w2animation"].speed = -1;
            w2windowanimation["w2animation"].time = w2windowanimation["w2animation"].length;
            w2windowanimation.Play();
        }
        else if (buttonname == "w3close")
        {
            w3windowanimation["w3animation"].speed = -1;
            w3windowanimation["w3animation"].time = w3windowanimation["w3animation"].length;
            w3windowanimation.Play();
        }
    }
}
