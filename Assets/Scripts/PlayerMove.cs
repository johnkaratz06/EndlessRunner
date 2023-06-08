using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float speed2;
    public Transform Player;
    public GameObject Player1;
    public GameObject score;
    public Transform Main_Camera;
    public int s = 0;
    public int t = 3;
    // Update is called once per frame
    void Awake()
    {
        StartCoroutine(Timet());
    }
    IEnumerator Timet()
    {
        score.SetActive(true);
        score.GetComponent<TMP_Text>().text = "" + t;
        yield return new WaitForSeconds(1);
        t = t - 1;
        score.GetComponent<TMP_Text>().text = "" + t;
        yield return new WaitForSeconds(1);
        t = t - 1;
        score.GetComponent<TMP_Text>().text = "" + t;
        yield return new WaitForSeconds(1);
        score.GetComponent<TMP_Text>().text = "Go";
        yield return new WaitForSeconds(1);
        speed = PlayerPrefs.GetFloat("Speed");
        score.SetActive(false);

    }
    void Update()
    {
        
        Player.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        if (Input.GetKeyDown("d") && GameObject.Find("Player").transform.position.x < 12f)
        {
            Player.transform.Translate(Vector3.right * speed * Time.deltaTime * 80);
            //rb.AddForce(600*Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("a") && GameObject.Find("Player").transform.position.x > -4f)
        {
            Player.transform.Translate(Vector3.left * speed * Time.deltaTime * 80);
        }
        Main_Camera.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        if (GameObject.Find("Player").transform.position.y < -2f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        score.transform.position = new Vector3(score.transform.position.x, score.transform.position.y, Player.transform.position.z-1);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "ground" && collision.collider.tag!="score" && collision.collider.tag != "minor")
        {
            Player1.SetActive(false);
            score.SetActive(true);
            score.GetComponent<TMP_Text>().text = "Score: "+s;
            Invoke("end", 5);
        }
        else if (collision.collider.tag == "score")
        {
            s = s + 1;
        }
    }
    private void OnGUI()
    {
        
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + s);
    }
    public void end()
    {
        SceneManager.LoadScene("start");
    }
    
}