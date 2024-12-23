using DefaultNamespace;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.TakeDamage(damage);
        }
    }
}