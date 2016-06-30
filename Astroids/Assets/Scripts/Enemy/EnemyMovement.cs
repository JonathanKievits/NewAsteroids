using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    public float rotationSpeed;
    public float movementSpeed;
    public float rotationTime;
    private float randomTime;
    public ParticleSystem particles1;

    void Start()
    {
        Invoke("ChangeRotation", rotationTime);
    }

    void ChangeRotation()
    {
        if (Random.value > 0.5f)
        {
            rotationSpeed = -rotationSpeed;
        }
        Invoke("ChangeRotation", rotationTime);
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Projectile"))
        {
            particles1.Play();
            Destroy(gameObject,1f);
        }
    }


    void Update()
    {
        randomTime = Random.Range(1, 3);
        rotationTime = randomTime;
        transform.Rotate(new Vector3(0, rotationSpeed, 0 * Time.deltaTime));
        transform.position += transform.forward * movementSpeed * Time.deltaTime;


    }
}
