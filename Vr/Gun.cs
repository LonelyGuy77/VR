using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public Transform muzzle;
    public Projectile projectile;
    public float msBetweenShots = 100;
    public float muzzleVelocity = 35;
    float nextShotTime;
    private AudioSource gunAudio;

    public void Shoot()
    {

        gunAudio = GetComponent<AudioSource>();

        if (Time.time > nextShotTime)//발사속도와 텀지정
        {
            nextShotTime = Time.time + msBetweenShots / 1000;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.SetSpeed(muzzleVelocity);
            gunAudio.Play();
        }
    }

}
