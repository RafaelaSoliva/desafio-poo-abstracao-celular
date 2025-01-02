namespace Models;

public class Aplicativo {
    public string Nome { get; set; }
    public float Tamanho { get; set; }

    public Aplicativo(String nome, float tamanho) {
        Nome = nome;
        Tamanho = tamanho;
    }
}