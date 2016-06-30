using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerShooting1_1 : MonoBehaviour
{

    public GameObject CannonBall;
    [SerializeField]private List<Transform> muzzles;
    public float BallSpeed;
    public float fireRate = 0.1F;
    public float nextFire = 0.5F;
    [SerializeField]private List<ParticleSystem> particles;
    public AudioSource audio;
    public AudioClip ShotSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles[0].Play();
            particles[1].Play();
            audio.PlayOneShot(ShotSound);
            ShootLeft1();
        }
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles[2].Play();
            particles[3].Play();
            audio.PlayOneShot(ShotSound);
            ShootRight1();
        }
        if (Input.GetKey(KeyCode.RightArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles[0].Play();
            particles[1].Play();
            audio.PlayOneShot(ShotSound);
            ShootLeft1();
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            particles[2].Play();
            particles[3].Play();
            audio.PlayOneShot(ShotSound);
            ShootRight1();
        }
    }

    private void ShootRight1()
    {
        Projectile newProjectileR1 = Instantiate(
            CannonBall,
            muzzles[2].position,
            muzzles[2].rotation) as Projectile;
        Projectile newProjectileR2 = Instantiate(
            CannonBall,
            muzzles[3].position,
            muzzles[3].rotation) as Projectile;
        newProjectileR1.SetSpeed(BallSpeed);
    }
    private void ShootLeft1()
    {
        Projectile newProjectileL1 = Instantiate(
            CannonBall,
            muzzles[0].position,
            muzzles[0].rotation) as Projectile;
        Projectile newProjectileL2 = Instantiate(
            CannonBall,
            muzzles[1].position,
            muzzles[1].rotation) as Projectile;
        newProjectileL1.SetSpeed(BallSpeed);
    }
}