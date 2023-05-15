using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Inglorious.Scripts;

public class Rising : IEnemyIA
{
	private CharacterController controller;
	private int battle_state = 0;

	public float runSpeed = 3.0f;
	public float turnSpeed = 60.0f;
	public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;
	private float w_sp = 0.0f;
	private float r_sp = 0.0f;

	public Transform objective;
	public float speed;
	public NavMeshAgent IA;
	public Animator anim;
	public string walk;
	public string attack;
	// Start is called before the first frame update
	void Start()
    {
		GameObject enemigoObjeto = GameObject.Find("Monster (3)");
		enemigoObjeto.SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
		

		//

		if (objective != null)
		{
			if (Vector3.Distance(gameObject.transform.position, objective.transform.position) < 100)
			{

				anim.SetTrigger("Rising");
			}
		}
		
	}
}
