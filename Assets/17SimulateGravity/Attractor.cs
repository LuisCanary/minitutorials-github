using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
	const float gravitationalConstant=6.674f;

	public static List<Attractor> Attractors;

	public Rigidbody rb;

	private void FixedUpdate()
	{
		Attractor[] attractors = FindObjectsOfType<Attractor>();

		foreach (Attractor attractor in Attractors)
		{
			if (attractor!=this)
			{
				Attract(attractor);
			}
		}
	}

	private void OnEnable()
	{
		if (Attractors==null)
		{
			Attractors = new List<Attractor>();
		}
		Attractors.Add(this);
	}
	private void OnDisable()
	{
		Attractors.Remove(this);
	}
	void Attract(Attractor objToAttract)
	{
		Rigidbody rbToAttract = objToAttract.rb;

		Vector3 direction = rb.position - rbToAttract.position;
		float distance = direction.magnitude;

		if (distance==0)
		{
			return;
		}

		float forceMagnitude = gravitationalConstant*(rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);//Physics formula of gravity

		Vector3 force = direction.normalized * forceMagnitude;

		rbToAttract.AddForce(force);
	}
}
