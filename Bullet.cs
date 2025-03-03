using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet colidiu com: " + other.gameObject.name); // Teste para debug

        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroi o inimigo
            Destroy(gameObject); // Destroi a bala
        }
    }
}
