using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plataformGoal : MonoBehaviour
{
    private bool _win;
    public float timer;
    public float timeToReset = 4f;
    public TextMeshProUGUI _winText;
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

        if (_win)
        {
            _winText.gameObject.SetActive(true);
            timer = timer + Time.deltaTime;

            if (timeToReset <= timer)
            {

                SceneManager.LoadScene("SampleScene");

            }
        }
    }
}
