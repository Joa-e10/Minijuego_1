using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plataformGoal : MonoBehaviour
{
    private bool _win;
    public float timer;
    public float timeToReset = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHeal playerHeal = collision.gameObject.GetComponent<playerHeal>();
        if (playerHeal == true)
        {
            _win = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (_win)
        {
            if (timeToReset < timer)
            {

                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
