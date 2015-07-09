using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour
{
	public void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit))
			{
				GameObject obj = hit.collider.gameObject;
				Character chara = obj.GetComponent<Character>();
				
				if (chara != null)
				{
					chara.Touch();
				}
			}
		}
	}
}
