using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Insecto : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI InsectosText;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        InsectosText.text = GameController.current.insectos.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.current.insectos = GameController.current.insectos + 5;
            Destroy(gameObject);
        }
    }
}
