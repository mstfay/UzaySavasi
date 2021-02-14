using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject explosionPrefab;

    GameControl gameControl;

    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        gameControl = Camera.main.GetComponent<GameControl>();

        float yon = Random.Range(0f, 1f);
        if (yon < 0.5)
        {
            rb.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb.AddTorque(yon * 5.0f);
        }
        else
        {
            rb.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb.AddTorque(-yon * 5.0f);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameControl.AsteroidDisappear(gameObject);
            AsteroidYokEt();
        }

    }

    public void AsteroidYokEt()
    {
        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
    //        Destroy(gameObject);
    //    }
    //}
}
