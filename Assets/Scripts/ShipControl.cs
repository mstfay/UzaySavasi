using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    GameObject explosionPrefab;

    GameControl gameControl;

    const float movementPower = 5;

    // Start is called before the first frame update
    void Start()
    {
        gameControl = Camera.main.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0)
        {
            position.x += horizontalInput * movementPower * Time.deltaTime;
        }
        if (verticalInput != 0)
        {
            position.y += verticalInput * movementPower * Time.deltaTime;
        }
        transform.position = position;

        if (Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>().Fire();
            Vector3 bulletPosition = gameObject.transform.position;
            bulletPosition.y += 1;
            Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
        }
    }
        void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag == "Asteroid")
            {
                GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>().ShipExplosion();
                gameControl.GameOver();
                Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    
}
