using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    const float movementPower = 10;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if(Input.GetButtonDown("Jump"))
        {
            Vector3 bulletPosition = gameObject.transform.position;
            bulletPosition.y += 1;
            Instantiate(bulletPrefab, bulletPosition, Quaternion.identity);
        }
    }
}
