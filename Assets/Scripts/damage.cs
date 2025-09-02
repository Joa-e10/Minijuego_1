using UnityEngine;
using UnityEngine.SceneManagement;

public class damage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHeal playerHeal = collision.gameObject.GetComponent<playerHeal>();

        if (playerHeal != null) {

            playerHeal.damagePlayer();

            SceneManager.LoadScene("SampleScene");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
