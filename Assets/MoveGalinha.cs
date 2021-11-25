using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGalinha : MonoBehaviour
{
	//centro da elipse
	float x;
	float z;
	
	//posição na elipse dada por esse valor unitario
	public float alpha;
	
	//posicao do objeto
	float X;
	float Z;

    // Start is called before the first frame update
    void Start()
    {
		//inicializa as variaveis
		x = 0;
		z = 0;
    }

    // Update is called once per frame
    void Update()
    {
		//aumenta a distancia percorrida por uma velociadade(1)
        alpha += 360*Time.deltaTime;
		
		//atualiza a posição do objeto para o novo alpha
		X = x + (10 * (float)System.Math.Cos(alpha*0.005));
		Z = z + (10 * (float)System.Math.Sin(alpha*0.005));
		transform.position = new Vector3(X,-1,Z);
		
        transform.eulerAngles = new Vector3(
							transform.eulerAngles.x,
							transform.eulerAngles.y - 103*Time.deltaTime,
							transform.eulerAngles.z
						);
		

    }
}
