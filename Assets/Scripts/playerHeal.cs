using UnityEngine;

public class playerHeal : MonoBehaviour
{
    public bool live = true;
    void Start()
    {
        
    }

    public void damagePlayer()
    {
        if (live == true)
        {
            live = false;
        }
        else
        {
        }

        // Update is called once per frame
    }
}
