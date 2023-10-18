using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class dz2 : MonoBehaviour
{
    private GameObject objj;
    
    // Start is called before the first frame update
    void Start()
    {
        objj = GameObject.FindWithTag("Counter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        TextMeshProUGUI txt = objj.GetComponent<TextMeshProUGUI>();
        txt.text = (Convert.ToInt32(txt.text) - 1).ToString();
    }
}
