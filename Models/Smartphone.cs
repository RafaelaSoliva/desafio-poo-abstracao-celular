namespace Models;

public abstract class Smartphone {
    // Declaração de propriedades
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string Imei { get; set; }
    private float MemoriaTotal { get; set; }
    protected float MemoriaDisponivel { get; set; }
    protected List<Aplicativo> AplicativosInstalados { get; set; }

    // Construção da classe
    public Smartphone(string numero, string modelo, string imei, float memoriaTotal) {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        MemoriaTotal = memoriaTotal;
        MemoriaDisponivel = memoriaTotal;
        AplicativosInstalados = new List<Aplicativo>();
    }

    // Métodos
    public void RealizarChamada(){
        Console.WriteLine("Realizando chamada..");
    }

    public void ReceberChamada() {
        Console.WriteLine("Recebendo chamada..");
    }

    public bool VerificarMemoriaDisponivel(float MemoriaDisponivel) {
        return MemoriaDisponivel > 0;
    }

    public void ListarAplicativosInstalados() {
        Console.WriteLine("Aplicativos instalados:");
        foreach(var Aplicativo in AplicativosInstalados) {
            Console.WriteLine($"{Aplicativo.Nome} - {Aplicativo.Tamanho} MB");
        }
    }

    public Aplicativo DesinstalarAplicativo(string nome) {
        Aplicativo aplicativo = AplicativosInstalados.Find(a => a.Nome == nome);
        AplicativosInstalados.Remove(aplicativo);
        MemoriaDisponivel = MemoriaDisponivel + aplicativo.Tamanho;
        Console.WriteLine($"{aplicativo.Nome} desinstalado! {aplicativo.Tamanho} MB liberados.");
        return aplicativo;
    }

    // Método abstrato (deve chamar o metodo VerificarMemoriaDisponivel)
    public abstract void InstalarAplicativo(string nome, float tamanho);
}