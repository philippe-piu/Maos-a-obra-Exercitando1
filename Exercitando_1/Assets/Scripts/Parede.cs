using UnityEngine;

public class Parede : MonoBehaviour
{
    // Velocidade da parede (provavelmente usada para mover obstáculos)
    public float obVelocidade;

    private void Start()
    {
        // Destroi o objeto após 5 segundos para evitar acúmulo de instâncias
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        // Move a parede para trás (sentido negativo do eixo Z)
        transform.Translate(-Vector3.forward * obVelocidade * Time.deltaTime);
    }
}
