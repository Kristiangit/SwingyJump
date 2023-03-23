using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresetSpawn : MonoBehaviour
{
    public GameObject Preset;
    public float spawnRate = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        } else {
            Debug.Log(timer);
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        GameObject newPreset = Instantiate(Preset, new Vector3(GameObject.Find("Player").transform.position.x + 20f, 0f, 0f), transform.rotation);
    }

}
