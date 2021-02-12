using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        UzayGemisi gemi1 = new UzayGemisi(Random.Range(30, 40));
        UzayGemisi gemi2 = new UzayGemisi(Random.Range(30, 40));

        //gemi1.Hizlandirici();
        //gemi2.Hizlandirici();

        gemi1.Yavaslatici();
        gemi2.Yavaslatici();

        if (gemi1.MaksimumHiz > gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi1 Kazandı.");
        }
        else if (gemi1.MaksimumHiz < gemi2.MaksimumHiz)
        {
            Debug.Log("Gemi2 Kazandı.");
        }
        else
        {
            Debug.Log("Berabere Bitti.");
        }

        //int saldiranDusman = 10;
        //bool saldiriDevam = true;

        //while (saldiriDevam)
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Saldiri altindayiz. Düşman sayısı: " + saldiranDusman);
        //}

        //do
        //{
        //    saldiranDusman--;
        //    if (saldiranDusman < 3)
        //    {
        //        saldiriDevam = false;
        //    }
        //    Debug.Log("Saldiri altindayiz. Düşman sayısı: " + saldiranDusman);
        //}
        //while (saldiriDevam);



        //int x = 6;                 
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

        //switch(x)
        //{
        //    case 1:
        //        Debug.Log("Güzel!");
        //        break;

        //    case 5:
        //        Debug.Log("Adamsın!");
        //        break;

        //    default:
        //        Debug.Log("Tutmadı be başkan");
        //        break;
    }



    // Update is called once per frame

}
