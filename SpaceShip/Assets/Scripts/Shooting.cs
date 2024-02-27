using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    [SerializeField] DynamicAimController aimController;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, shootPoint.position,shootPoint.transform.rotation);

            newBullet.transform.LookAt(aimController.aimPosition);

            Destroy(newBullet, 3f);
        }
    }

}
