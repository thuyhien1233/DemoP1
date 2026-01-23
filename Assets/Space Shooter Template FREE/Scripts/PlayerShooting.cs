using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Singleton
    public static PlayerShooting instance;

    [Header("Bullet")]
    public GameObject bulletPrefab;

    [Header("Weapon Power")]
    public int weaponPower = 1;
    public int maxweaponPower = 3;   // 👈 GIỮ ĐÚNG TÊN NÀY

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (weaponPower == 1)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
        else if (weaponPower == 2)
        {
            Instantiate(bulletPrefab, transform.position + Vector3.left * 0.2f, transform.rotation);
            Instantiate(bulletPrefab, transform.position + Vector3.right * 0.2f, transform.rotation);
        }
        else
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Instantiate(bulletPrefab, transform.position + Vector3.left * 0.3f, transform.rotation);
            Instantiate(bulletPrefab, transform.position + Vector3.right * 0.3f, transform.rotation);
        }
    }
}
