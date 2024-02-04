// Estructura_De_Decision.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "iostream"
#include <math.h>

using namespace std;
int main()
{
	int Opcion, Opcion2, Opcion3;
	//Se muestra un mensaje por pantalla.
	cout << "Seleccione Una Opcion" << "\n";
	cout << "1. Figuras Geometricas" << "\n";
	cout << "2. Cuerpo Geometricos" << "\n";
	cin >> Opcion;


	if (Opcion == 1) {
		system("CLS()");
		cout << "Seleccione Una Opcion" << "\n";
		cout << "1. Rombo " << "\n";
		cout << "2. Pentagono" << "\n";
		cout << "3. Corona Circular" << "\n";
		cout << "4. Paralelogramo" << "\n";
		cin >> Opcion2;

		if (Opcion2 == 1) {
			system("CLS()");
			double Area, Diagonal1, Diagonal2;
			cout << "Digite El Valor De La Diagonal N1 Del Rombo" << "\n";
			cin >> Diagonal1;
			cout << "Digite El Valor De La Diagonal N2 Del Rombo" << "\n";
			cin >> Diagonal2;

			Area = (Diagonal1*Diagonal2) / 2;
			cout << "El Area Del Rombo Es:  " << Area << "\n";
			system("PAUSE()");
		}
		else
		{
			{
				if (Opcion2 == 2) {
					system("CLS()");
					double Area, longitud, apotema;
					cout << "Digite El Valor De La longitud Del Pentagono" << "\n";
					cin >> longitud;
					cout << "Digite El Valor De La apotema Del Pentagono" << "\n";
					cin >> apotema;

					Area = (5*longitud*apotema) / 2;
					cout << "El Area Del Pentagono Es:  " << Area << "\n";
					system("PAUSE()");
				}
				else
				{
					if (Opcion2 == 3) {
						system("CLS()");
						double Area, círculo_mayor, círculo_menor;
						cout << "Digite El Valor Del Circulo Mayor De La Corona Circular" << "\n";
						cin >> círculo_mayor;
						cout << "Digite El Valor Del Circulo Menor De La Corona Circular" << "\n";
						cin >> círculo_menor;

						Area = 3.14*(círculo_mayor*círculo_menor);
						cout << "El Area De La Corona Circular Es:  " << Area << "\n";
						system("PAUSE()");
					}
					else
					{
						if (Opcion2 == 4) {
							system("CLS()");
							int Area, Base, Altura;
							cout << "Digite El Valor De La Base Del Paralelogramo" << "\n";
							cin >> Base;
							cout << "Digite El Valor De La Altura Del Paralelogramo" << "\n";
							cin >> Altura;

							Area = Base*Altura;
							cout << "El Area Del Paralelogramo Es:  " << Area << "\n";
							system("PAUSE()");
						}
						else
						{
							system("CLS()");
							cout << "Lo Sentimos, Esa Opcion No Se Encuentra En Nuestras Opciones" << "\n";
							system("PAUSE()");
						}
					}
				}
			}
		}
	}else
	{
		if (Opcion == 2) {
			system("CLS()");
			cout << "Seleccione Una Opcion" << "\n";
			cout << "1. Cono " << "\n";
			cout << "2. Cilindro" << "\n";
			cout << "3. Cubo" << "\n";
			cout << "4. Esfera" << "\n";
			cin >> Opcion3;

			if (Opcion3 == 1) {
				system("CLS()");
				double Volumen, Radio, Altura;
				cout << "Digite El Valor Del Radio Del Cono" << "\n";
				cin >> Radio;
				cout << "Digite El Valor Del La Altura Del Cono" << "\n";
				cin >> Altura;

				Volumen = (1/3)*(3.14*pow(Radio,2))*Altura;
				cout << "El Volumen Del Cono Es:  " << Volumen << "\n";
				system("PAUSE()");
			}
			else
			{
				if (Opcion3 == 2) {
					system("CLS()");
					double Volumen, Radio, Altura;
					cout << "Digite El Valor Del Radio Del Cilindro" << "\n";
					cin >> Radio;
					cout << "Digite El Valor Del La Altura Del Cilindro" << "\n";
					cin >> Altura;

					Volumen = (3.14*pow(Radio, 2))*Altura;
					cout << "El Volumen Del Cilindro Es:  " << Volumen << "\n";
					system("PAUSE()");
				}
				else
				{
					if (Opcion3 == 3) {
						system("CLS()");
						int Volumen, Lado;
						cout << "Digite El Valor Del Lado Del Cubo" << "\n";
						cin >> Lado;

						Volumen = pow(Lado, 3);
						cout << "El Volumen Del Cubo Es:  " << Volumen << "\n";
						system("PAUSE()");
					}
					else
					{
						if (Opcion3 == 4) {
							system("CLS()");
							double Volumen, Radio;
							cout << "Digite El Valor Del Radio De La Esfera" << "\n";
							cin >> Radio;

							(4 / 3)*(3.14*pow(Radio, 3));
							cout << "El Volumen De La Esfera Es:  " << Volumen << "\n";
							system("PAUSE()");
						}
						else
						{
							system("CLS()");
							cout << "Lo Sentimos, Esa Opcion No Se Encuentra En Nuestras Opciones" << "\n";
							system("PAUSE()");
						}
					}
				}
			}

		}else
		{
			system("CLS()");
			cout << "Lo Sentimos, Esa Opcion No Se Encuentra En Nuestras Opciones" << "\n";
			system("PAUSE()");
		}
	}

    return 0;
}

