using UnityEngine;

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
        }
    }
}
