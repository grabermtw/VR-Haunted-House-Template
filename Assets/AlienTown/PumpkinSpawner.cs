using UnityEngine;

public class PumpkinSpawner : MonoBehaviour
{

    public GameObject pumpkin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject newPump = Instantiate(pumpkin, new Vector3 (Random.Range(-250, 250), Random.Range(0,100), Random.Range(-250, 250)), Quaternion.identity, transform);
        newPump.GetComponent<Rigidbody>().AddForce(new Vector3 (Random.Range(-250, 250), Random.Range(0,100), Random.Range(-250, 250)));
    }
}
