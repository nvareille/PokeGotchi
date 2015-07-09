using UnityEngine;
using System.Collections;

public class EggController : Character
{
	public override void Touch()
	{
		Animator anim = GetComponent<Animator>();
		
		anim.SetTrigger("Happy");
		//Animation anim = GetComponent<Animation>();
		
		//anim.Play("Egg Happy");
	}
}
