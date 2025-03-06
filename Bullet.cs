using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionEffect;
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, other.transform.position, Quaternion.identity);
            }
            else
            {
                Debug.LogError("ExplosionEffect não está atribuído no Bullet!");
            }

            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(10);
            }
            else
            {
                Debug.LogError("ScoreManager.instance está NULL!");
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
