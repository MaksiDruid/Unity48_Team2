using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private int maxHealth;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void GetDamage(int _damage)
    {
        healthBar.SetBarValue(currentHealth, maxHealth);
        currentHealth -= _damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            if (gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(0);
                Cursor.visible = true;
            }
        }
    }
}
