using System. Collections;
using System. Collections.Generic;
using UnityEngine;


public class Deplacement: MonoBehaviour
{
	public float vitesse;
	
	private Transform voiture;
	private GestionVoiture gestion;
	private float periode;
	private Vector3 direction;
	
	
	void Start ()
	{
		this. voiture = transform;
		this. gestion = new GestionVoiture ();
	}
	
	
	void Update ()
	{
		this. periode = Time. deltaTime;
		this. controle ();
		if (this. gestion. roule (this. vitesse * this. periode / 2))
		{
			this. voiture. position += this. direction * this. vitesse * this. periode;
		}
	}
	
	private void controle ()
	{
		// Tourner à gauche
		if (Input. GetKey (KeyCode. LeftArrow))
		{
			this. voiture. Rotate (0, - this. vitesse * this. periode, 0);
		}
		
		// Tourner à droite
		else if (Input. GetKey (KeyCode. RightArrow))
		{
			this. voiture. Rotate (0, this. vitesse * this. periode, 0);
		}
		
		// Avancer
		if (Input. GetKey (KeyCode. UpArrow))
		{
			this. direction = Vector3. forward;
		}
		
		// Reculer
		else if (Input. GetKey (KeyCode. DownArrow))
		{
			this. direction = Vector3. back;
		}
		
		// Rester sur place
		else
		{
			this. direction = Vector3. zero;
		}
	}
}
