using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public GameObject Sprechblase;
    public GameObject SprechblaseFalsch;



    private float timer;

	// Use this for initialization
	void Start () {
        Vector2 position = new Vector2(Random.Range(-25.0f, 25.0f), 14.3f);
       Instantiate(Sprechblase, position, Quaternion.identity);
       Instantiate(SprechblaseFalsch, position, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
        float randTimer = Random.Range(1f, 3f);
        Vector2 position = new Vector2(Random.Range(-25.0f, 25.0f), 14.3f);
        if (timer > randTimer) {
            timer = 0;

            float randNumber = Random.Range(0.0f, 100.0f);
            if (randNumber > 25){
                Instantiate(Sprechblase, position, Quaternion.identity);
            } else {
                Instantiate(SprechblaseFalsch, position, Quaternion.identity);
            }
        }

        timer += Time.deltaTime;



	}
}
