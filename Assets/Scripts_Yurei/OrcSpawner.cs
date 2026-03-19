using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcSpawner : MonoBehaviour
{
    public GameObject Orc;
    public float delay = 4f;
    public float timer;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            float x = Random.Range(-8f, 8f);
            float y = Random.Range(-8f, 8f);
            Vector3 Random_Position = new Vector3(x, y, 0f);
            Instantiate(Orc, Random_Position, Quaternion.identity);
            
            timer = 0f;
        }
    }

    private void FixedUpdate()
    {
       
    }

}
