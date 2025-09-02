using Unity.VisualScripting;
using UnityEngine;

public class plataformTime : MonoBehaviour
{
    public bool breaking;
    public float timer;
    public float timeToReset = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHeal playerHeal = collision.gameObject.GetComponent<playerHeal>();
        if (playerHeal == true)
        {
            breaking = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (breaking)
        {
            if (timeToReset < timer) {

                Destroy(gameObject);
            }
        }
    }
}
