using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Inglorious.Scripts;
public class Walking : IEnemyIA
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
	

	// Use this for initialization
	void Start()
	{


		GameObject enemigoObjeto = GameObject.Find("Monster");
		enemigoObjeto.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		IA.speed = speed;

		//
		if (Vector3.Distance(gameObject.transform.position, objective.transform.position) < 10)
		{

			IA.SetDestination(objective.position);
		}
		//
		if (IA.speed > 0)
		{
			anim.SetFloat("Move", 1); // numero, el del condicional
		}
		if (IA.speed == 0)
		{
			anim.SetFloat("Move", 0); //no movement
		}
		if (Vector3.Distance(gameObject.transform.position, objective.transform.position) < 3)
		{
			//anim.SetTrigger("Attack");
			anim.SetTrigger("Jump");
			Debug.Log("esta saltando");
		}

	}
}
