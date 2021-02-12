using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GeriSayimSayaci countDownCounter;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10), ForceMode2D.Impulse);
        countDownCounter = gameObject.AddComponent<GeriSayimSayaci>();
        countDownCounter.ToplamSure = 3;
        countDownCounter.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (countDownCounter.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
