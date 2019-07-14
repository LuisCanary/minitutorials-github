using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour {

    public float healthLenght = 200;
    public float healthPos = 120;
    public GameObject healthBar;
    public float damageAmount;
    public bool decreasingHealth=false;
    public bool increasingHealth=false;
    public float hitValue = 30;


	void Start () {
        StartCoroutine(HealthChange());
	}
	
	
	void Update () {

		 healthBar.transform.position = new Vector2(healthPos, 30);
         healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(healthLenght, 30);
        if (decreasingHealth==true)
        {
            if (damageAmount>=hitValue)
            {
                decreasingHealth = false;
                damageAmount = 0;
            }
            else
            {
                damageAmount += 0.5f;
                healthLenght -= 0.5f;
                healthPos -= 0.25f;

            }
        }
        if (increasingHealth==true)
        {
            if (damageAmount>=hitValue*2)
            {
                increasingHealth = false;
                damageAmount = 0;
            }
            else
            {
                damageAmount += 0.5f;
                healthLenght += 0.5f;
                healthPos += 0.25f;
            }
        }

	}
    IEnumerator HealthChange()
    {
        yield return new WaitForSeconds(2);
        decreasingHealth = true;
        yield return new WaitForSeconds(3);
        decreasingHealth = true;
        yield return new WaitForSeconds(3);
        decreasingHealth = true;
        yield return new WaitForSeconds(3);
        increasingHealth = true;
    }
}
