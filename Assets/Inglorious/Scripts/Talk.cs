	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.AI;
	using Inglorious.Scripts;
	public class Talk : IEnemyIA
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

			/*anim = GetComponent<Animator>();
			controller = GetComponent<CharacterController> ();
			w_sp = speed; //read walk speed
			r_sp = runSpeed; //read run speed
			battle_state = 0;
			runSpeed = 1;*/
	
		}

		// Update is called once per frame
		void Update()
		{
		if (objective != null)
		{

			IA.speed = speed;

			//
			if (Vector3.Distance(gameObject.transform.position, objective.transform.position) < 100)
			{

				//IA.SetDestination(objective.position);
				anim.SetTrigger("How"); //no movement
			}

		}
			
			//

		


		}
	}
