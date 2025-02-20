
using System.Collections.Generic;
using UnityEngine;

public class Prefab : MonoBehaviour
{
    // Lista de objetos (prefabs) que podem ser instanciados
    public List<GameObject> Ob = new List<GameObject>();

    // Tempo entre cada spawn de um novo objeto
    public float spawnerObTempo = 5f;

    // Contador de tempo para controlar o intervalo de spawn
    private float tempoCont;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Chama a função que gerencia a criação de novos objetos
        InstantiatePrefab();
    }

    // Função responsável por instanciar um novo prefab em intervalos de tempo definidos
    public void InstantiatePrefab()
    {
        // Atualiza o contador de tempo
        tempoCont += Time.deltaTime;
        // Verifica se o tempo decorrido atingiu o tempo definido para spawn
        if (tempoCont >= spawnerObTempo) {

            // Instancia um objeto aleatório da lista na posição e rotação do objeto atual
            Instantiate(Ob[Random.Range(0, Ob.Count)], transform.position, transform.rotation);
            // Reseta o contador de tempo
            tempoCont = 0;

           
        
        }
    }
}
