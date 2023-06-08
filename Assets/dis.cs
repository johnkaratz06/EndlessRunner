using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dis : MonoBehaviour
{
    public Transform Cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "player")
        {
            Cube.transform.position += new UnityEngine.Vector3(Cube.position.x, -100, Cube.position.z);
        }
        
    }
}
