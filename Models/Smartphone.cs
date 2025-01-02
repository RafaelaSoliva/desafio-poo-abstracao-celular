namespace Models;

public abstract class Smartphone {
    // Declaração de propriedades
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string Imei { get; set; }
    private int MemoriaTotal { get; set; }
    protected int MemoriaDisponivel { get; set; }

    // Construção da classe
    public Smartphone(string numero, string modelo, string imei, int memoriaTotal) {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        MemoriaTotal = memoriaTotal;
        MemoriaDisponivel = memoriaTotal;
    }

    // Métodos
    public void RealizarChamada(){
        Console.WriteLine("Realizando chamada..");
    }

    public void ReceberChamada() {
        Console.WriteLine("Recebendo chamada..");
    }

    public bool VerificarMemoriaDisponivel(int MemoriaDisponivel) {
        return MemoriaDisponivel > 0;
    }

    // Método abstrato (deve chamar o metodo VerificarMemoriaDisponivel)
    public abstract void InstalarAplicativo(string nome);
}