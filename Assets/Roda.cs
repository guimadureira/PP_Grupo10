using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roda : MonoBehaviour
{
	
	float anguloX;
	float anguloY;
	float anguloYatual;
	float anguloXatual;
	public int rodaFrente;
	
    // Start is called before the first frame update
    void Start()
    {
        anguloX = 360f;
		anguloYatual = 0;
		anguloY = 30f;
		anguloXatual = 0;
    }

    // Update is called once per frame
    void Update()
    {
		GameObject carro = gameObject.transform.parent.gameObject.transform.parent.gameObject;

		anguloXatual = anguloX*Time.deltaTime;
		if(rodaFrente == 1){
			if(carro.transform.position.z < -30){
				
				if(carro.transform.position.x < 0){
					if(anguloYatual <= 35){
						transform.eulerAngles = new Vector3(
							transform.eulerAngles.x,
							transform.eulerAngles.y - anguloY*Time.deltaTime,
							transform.eulerAngles.z
						);
						anguloYatual += anguloY*Time.deltaTime;
					}
					
				}else{
					if(anguloYatual > 0){
						transform.eulerAngles = new Vector3(
							transform.eulerAngles.x,
							transform.eulerAngles.y + anguloY*Time.deltaTime,
							transform.eulerAngles.z
						);	
						anguloYatual -= anguloY*Time.deltaTime;
					}
				}
				
			}else if(carro.transform.position.z > 30){
				
				if(carro.transform.position.x > 0){
					if(anguloYatual <= 35){
						transform.eulerAngles = new Vector3(
							transform.eulerAngles.x,
							transform.eulerAngles.y - anguloY*Time.deltaTime,
							transform.eulerAngles.z
						);
						anguloYatual += anguloY*Time.deltaTime;
					}
					
				}else{
					if(anguloYatual > 0){
					transform.eulerAngles = new Vector3(
						transform.eulerAngles.x,
						transform.eulerAngles.y + anguloY*Time.deltaTime,
						transform.eulerAngles.z
					);	
					anguloYatual -= anguloY*Time.deltaTime;
					}
				}
				
			}else if(anguloYatual > 0){
				transform.eulerAngles = new Vector3(
					transform.eulerAngles.x,
					transform.eulerAngles.y + anguloY*Time.deltaTime,
					transform.eulerAngles.z
				);
				
				anguloYatual -= anguloY*Time.deltaTime;
			}
		}
		transform.Rotate(anguloXatual,0,0);
		//else{
			//transform.eulerAngles = new Vector3(
			//	AnguloXatual,
			//	transform.eulerAngles.y,
			//	transform.eulerAngles.z
			//);

		//}
    }
}
