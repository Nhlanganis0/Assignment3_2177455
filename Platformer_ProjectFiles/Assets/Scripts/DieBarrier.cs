using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieBarrier : MonoBehaviour
{
	public float speed;
	public GameObject object1; 
	public GameObject object2;

	public void Update()
	{
		StartCoroutine(DelayDeath());
	}

	IEnumerator DelayDeath()
	{
		yield return new WaitForSeconds(2);
		Vector3 dirction = object1.transform.position - object2.transform.position;
		dirction = -dirction.normalized;

		object1.transform.position += dirction * Time.deltaTime * speed;
	}
}
