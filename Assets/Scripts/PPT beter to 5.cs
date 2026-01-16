using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class PPTbeterto5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int rondasTotales = 5;
        int rondaActual = 1;

        int puntosJugadorA = 0;
        int puntosJugadorB = 0;

        void Start()
        {
            
        }

        {
            while (rondaActual <= rondasTotales)
            {
                Debug.Log("Ronda " + rondaActual);

                string jugadorA = ElegirJugador();
                string jugadorB = ElegirCPU();

                Debug.Log("JugadorA: " + jugadorA);
                Debug.Log("JugadorB: " + jugadorB);

                string resultado = DeterminarGanador(jugadorA, jugadorB);
                Debug.Log("Resultado: " + resultado);

                rondaActual++;

            }

            Debug.Log("Juego terminado");
            Debug.Log("Puntos JugadorA: " + puntosJugadorA);
            Debug.Log("Puntos JugadorB: " + puntosJugadorB);

            if (puntosJugadorA > puntosJugadorB) Debug.Log("Gana el JugadorA");
            else if (puntosJugadorA < puntosJugadorB) Debug.Log("Gana el JugadorB");
            else Debug.Log("Empate");
        }

        string ElegirJugador()
        {
            string[] opciones = { "Piedra", "Papel", "Tijeras" };
            int indice = Random.Range(0, opciones.Length);
            return opciones[indice];
        }

        string ElegirCPU()
        {
            string[] opciones = { "Piedra", "Papel", "Tijeras" };
            int indice = Random.Range(0, opciones.Length);
            return opciones[indice];
        }

        string DeterminarGanador(string jugador, string cpu)
        {
            if (jugador == cpu) return "Empate";

            if ((jugador == "Piedra" && cpu == "Tijeras") ||
                (jugador == "Papel" && cpu == "Piedra") ||
                (jugador == "Tijeras" && cpu == "Papel"))
            {
                puntosJugadorA++;
                return "Gana el jugadorA";
            }
            else
            {
                puntosJugadorB++;
                return "Gana la jugadorB";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
