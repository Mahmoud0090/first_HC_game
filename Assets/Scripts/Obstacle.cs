using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstacle : MonoBehaviour
{
    public float speed = 10f;
    public TextMeshProUGUI text;

    void Start()
    {
        text = GameObject.Find("scoreText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Out")
        {
            int newScore = int.Parse(text.text) + 1;
            text.text = newScore.ToString();
            Destroy(gameObject);
        }

    }
}
