using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
       // obj = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    public void actdeact1()
    {
       // if (Input.GetKeyDown(KeyCode.Space))
      //  {
            if (obj.activeSelf)
            {
                obj.SetActive(false);
            }
            else
                obj.SetActive(true);
       // }
    }
    
}
