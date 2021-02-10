using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 6;
        //ek yorum satırı
        //if (20<x && x<=30)
        //{
        //    Debug.Log("Ebenin Amı!");
        //}
        //else if (30<x && x<=99)
        //{
        //    Debug.Log("Ananın Amı!");
        //}
        //else if (100<x && x != 150)
        //{
        //    Debug.Log("Ultra Ananın Amı!");
        //}
        //else
        //{
        //    Debug.Log("Sıkıntı yooook!");
        //}

        switch(x)
        {
            case 1:
                Debug.Log("Güzel!");
                break;

            case 5:
                Debug.Log("Adamsın!");
                break;

            default:
                Debug.Log("Tutmadı be başkan");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
