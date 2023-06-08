using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatesections : MonoBehaviour
{
    public GameObject[] sections;
    public float zPos;
    public bool create = false;
    public int section;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (create == false)
        {
            create = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        section = Random.Range(0, 3);
        Instantiate(sections[section],new Vector3(0,0,zPos),Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(10);
        create = false;
    }
}
