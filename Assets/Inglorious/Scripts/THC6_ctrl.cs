using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using Inglorious.Scripts;
public class THC6_ctrl : IEnemyIA
{
	
	public int saludMaxima = 100; // La salud máxima del personaje
	public int saludActual; // La salud actual del personaje
	public int dañoRecibido = 10; // La cantidad de daño que recibe el personaje al ser golpeado



	private CharacterController controller;



	public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;


	public Transform objective;
	public float speed ;
	public NavMeshAgent IA;
	public Animator anim;
	public string walk;
	public string attack;
	public float radioAtaque = 2f; // La distancia máxima a la que el enemigo puede atacar al personaje
	public int dañoAtaque = 10; // La cantidad de daño que el enemigo inflige al personaje

	private GameObject Player; // La referencia al objeto del jugador
							   // Use this for initialization
	void Start()
	{


		GameObject enemigoObjeto = GameObject.Find("Monster");
		enemigoObjeto.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		
		
		if (objective!=null)
		{
			IA.speed = speed;
			if (Vector3.Distance(gameObject.transform.position, objective.transform.position) < 10f)
			{
				IA.SetDestination(objective.position);


			}
			

			if (IA.speed > 0)
			{
				anim.SetFloat("Move", 1); // numero, el del condicional
			}
			if (IA.speed == 0)
			{
				anim.SetFloat("Move", 0);
			}
			if (Vector3.Distance(gameObject.transform.position, objective.transform.position) < 100f)
			{
				anim.SetTrigger("Attack");


			}
		}
			

		
			

	}

	
}



