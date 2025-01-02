namespace Models;

public class Aplicativo {
    // Declaração de propriedades
    public string Nome { get; set; }
    public float Tamanho { get; set; }

    // Construção da classe
    public Aplicativo(String nome, float tamanho) {
        Nome = nome;
        Tamanho = tamanho;
    }
}