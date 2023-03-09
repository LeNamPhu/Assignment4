using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public GameObject itemFeedback;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddPoint(1000);
            Instantiate(itemFeedback, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
