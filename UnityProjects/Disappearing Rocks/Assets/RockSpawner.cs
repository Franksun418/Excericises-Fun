using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour {

    Timer spawnTimer;
    [SerializeField]
    GameObject rock;

    [SerializeField]
    Sprite GreenRock;
    [SerializeField]
    Sprite MagentaRock;
    [SerializeField]
    Sprite WhiteRock;
	// Use this for initialization
	void Start () {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();

	}
	
	// Update is called once per frame
	void Update () {
        if (spawnTimer.Finished && GameObject.FindGameObjectsWithTag("Rock").Length<3)
        {
            
            spawnTimer.Run();
            Vector3 position = new Vector3(transform.position.x, transform.position.y, 0);
            Instantiate<GameObject>(rock, position, Quaternion.identity);
            int num = Random.Range(0, 3);

            switch (num)
            {
                case 0:
                    rock.GetComponent<SpriteRenderer>().sprite = GreenRock;
                    break;
                case 1:
                    rock.GetComponent<SpriteRenderer>().sprite = MagentaRock;
                    break;
                case 2:
                    rock.GetComponent<SpriteRenderer>().sprite = WhiteRock;
                    break;
            }


        }
	}
}
