using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private AudioSource _headShot;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    private void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.GetComponent<Enemy>())
        {
            GameObject enemy = hit.collider.gameObject.GetComponent<Enemy>().gameObject;
            _headShot.Play();

            Destroy(enemy);
        }
    }
}
