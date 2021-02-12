using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    GameObject shipPrefab;

    List<GameObject> asteroidList = new List<GameObject>();

    GameObject ship;

    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        ship = Instantiate(shipPrefab);
        ship.transform.position = new Vector3(0, EkranHesaplayicisi.Alt + 1.5f);
        AsteroidUret(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AsteroidUret(int adet)
    {
        Vector3 position = new Vector3();

        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(EkranHesaplayicisi.Sol + 0.4f, EkranHesaplayicisi.Sag - 0.4f);
            position.y = EkranHesaplayicisi.Ust - 1;

            GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0, 3)], position, Quaternion.identity);
            asteroidList.Add(asteroid);
        }
    }
}
