using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCarro : MonoBehaviour
{
	//variaveis

	//semi-eixo menor
	float a;
	//semi-eixo maior
	float b;
	
	//centro da elipse
	float x;
	float z;
	
	float anguloCurva;
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
		a = 23;
		b = 50;
		anguloCurva = -70f;
    }

    // Update is called once per frame
    void Update()
    {
		//aumenta a distancia percorrida por uma velociadade(1)
        alpha += 130*Time.deltaTime;
		
		//atualiza a posição do objeto para o novo alpha
		X = x + (a * (float)System.Math.Cos(alpha*0.005));
		Z = z + (b * (float)System.Math.Sin(alpha*0.005));
		transform.position = new Vector3(X,-1,Z);
		
		//if que faz o carro rodar nas curvas
		if(Z >= 25){//checa se o carro esta na curva de baixo
			if(transform.localEulerAngles.y%360 >= 180 || transform.localEulerAngles.y%360 == 0){
				//faz a rotação do carro até um angulo maximo
				transform.Rotate(0, anguloCurva*Time.deltaTime, 0);
			}
		}else if(Z <= -25){//checa se o carro esta na curva de cima
			if(transform.localEulerAngles.y%360 <= 180){
				//faz a rotação do carro até um angulo maximo
				transform.Rotate(0, anguloCurva*Time.deltaTime, 0);
			}
		}else if(X < 0){//completa a rotação do carro caso não termine na curva da pista
			if(transform.localEulerAngles.y%360 >= 180 || transform.localEulerAngles.y%360 == 0){
				//faz a rotação do carro até um angulo maximo
				transform.Rotate(0, anguloCurva*Time.deltaTime, 0);
			}
		}else{//completa a rotação do carro caso não termine na curva da pista
			if(transform.localEulerAngles.y%360 <= 180){
				//faz a rotação do carro até um angulo maximo
				transform.Rotate(0, anguloCurva*Time.deltaTime, 0);
			}
		}
		

    }
}
