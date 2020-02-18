using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preview : MonoBehaviour
{
    void Start()
    {
        open();
    }

    void Update()
    {
        
    }

    void open()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("x",  0.0f);
        hashtable.Add("time", 1.0f);
        hashtable.Add("easytype", iTween.EaseType.easeInBack);
        iTween.MoveTo(this.gameObject, hashtable);
    }
}
