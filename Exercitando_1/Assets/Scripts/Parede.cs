using UnityEngine;

public class Parede : MonoBehaviour
{
    // Velocidade da parede (provavelmente usada para mover obst�culos)
    public float obVelocidade;

    private void Start()
    {
        // Destroi o objeto ap�s 5 segundos para evitar ac�mulo de inst�ncias
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        // Move a parede para tr�s (sentido negativo do eixo Z)
        transform.Translate(-Vector3.forward * obVelocidade * Time.deltaTime);
    }
}
