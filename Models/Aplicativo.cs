namespace Models;

public class Aplicativo {
    // Declaração de propriedades
    public string Nome { get; set; }
    public int Tamanho { get; set; }

    // Construção da classe
    public Aplicativo(String nome, int tamanho) {
        Nome = nome;
        Tamanho = tamanho;
    }
}