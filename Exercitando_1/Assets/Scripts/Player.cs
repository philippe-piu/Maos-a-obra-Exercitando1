using UnityEngine;

public class Player : MonoBehaviour
{
    // Velocidade de movimentação do jogador
    public float velocidade;
    // Velocidade de rotação do jogador
    public float rotation;


    // Update is called once per frame
    void Update()
    {
        // Chama a função responsável pelo movimento do jogador
        MovimentoPlayer();
    }

    // Função para movimentar o jogador com base na entrada do teclado
    public void MovimentoPlayer()
    {
        // Movimenta o jogador para frente ao pressionar a seta para cima
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }

        // Movimenta o jogador para trás ao pressionar a seta para baixo
        if (Input.GetKey(KeyCode.DownArrow))
            if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * velocidade * Time.deltaTime);
        }

        // Rotaciona o jogador para a esquerda ao pressionar a seta para a esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(-Vector3.up * rotation * Time.deltaTime);
        }

        // Rotaciona o jogador para a direita ao pressionar a seta para a direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.down * rotation * Time.deltaTime);

        }
    }
}
