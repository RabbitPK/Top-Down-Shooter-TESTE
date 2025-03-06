using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private Transform player;
    public float damage = 10f; // Dano causado ao jogador

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            player = playerObj.transform;
        }
        else
        {
            Debug.LogError("Jogador não encontrado! Verifique se o Player tem a tag correta.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Inimigo colidiu com o Player!");
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage); // Aplica dano ao jogador
            Destroy(gameObject); // Destroi o inimigo
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(damage); // Aplica dano ao jogador
            Destroy(gameObject); // Destroi o inimigo
        }
    }
}
