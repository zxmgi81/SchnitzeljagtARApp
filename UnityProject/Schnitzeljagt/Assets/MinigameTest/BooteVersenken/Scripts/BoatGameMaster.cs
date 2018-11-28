using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatGameMaster : MonoBehaviour {

    public static BoatGameMaster Instance;

    public GameObject Boat;
    public Transform BoatSpawn1;
    public Transform BoatSpawn2;

    private Vector3 BoatSpawnDirection;
    private float BoatSpawnLength;

    private float timer;

	void Start ()
    {
        BoatSpawnDirection = (BoatSpawn2.position - BoatSpawn1.position).normalized;
        BoatSpawnDirection.y = 0;
	}
	

	void Update ()
    {
		if(timer < 0)
        {
            BoatSpawnLength = Random.Range(10f, 30f);
            Instantiate(Boat, transform.position + BoatSpawnDirection * BoatSpawnLength, Quaternion.identity);
            timer = Random.Range(0.7f, 2f);
        }

        timer -= Time.deltaTime;
	}




}
