using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject retry;
    public static bool lose = false;

    void Awake()
    {
        lose = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            lose = true;
            retry.SetActive(true);
        }
    }
    
}
