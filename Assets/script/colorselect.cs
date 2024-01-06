using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class colorselect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void color1()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if (buttonname == "black")
        {
            Color myclor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myclor);
            band1.color = myclor;
        }
        else if (buttonname == "blue")
        {
            Color myclor = new Color();
            ColorUtility.TryParseHtmlString("#343691", out myclor);
            band1.color = myclor;
        }
    }
    public void color2()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if (buttonname == "black")
        {
            Color myclor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myclor);
            band2.color = myclor;
        }
        else if (buttonname == "red")
        {
            Color myclor = new Color();
            ColorUtility.TryParseHtmlString("#CF403C", out myclor);
            band2.color = myclor;
        }
    }
    public void color3()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if (buttonname == "black")
        {
            Color myclor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myclor);
            band3.color = myclor;
        }
        else if (buttonname == "white")
        {
            Color myclor = new Color();
            ColorUtility.TryParseHtmlString("#E7E2E2", out myclor);
            band3.color = myclor;
        }
    }
}