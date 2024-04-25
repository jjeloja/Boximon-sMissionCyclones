using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
	public float countClicks;
	public TMP_Text countText;

    Vector3 launcher;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, launchVelocity, 0));
			countClicks++;
			countText.text = "Amount of Projectiles Shot: " + countClicks.ToString();
		}

        launcher = transform.localPosition;
        transform.localPosition = launcher;
    }
}
