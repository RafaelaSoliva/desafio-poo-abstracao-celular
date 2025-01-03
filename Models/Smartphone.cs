namespace Models;

public abstract class Smartphone {
    // Declaração de propriedades
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string Imei { get; set; }
    private int MemoriaTotal { get; set; }
    protected int MemoriaDisponivel { get; set; }
    protected List<Aplicativo> AplicativosInstalados { get; set; }

    // Construção da classe
    public Smartphone(string numero, string modelo, string imei, int memoriaTotal) {
        Numero = numero;
        Modelo = modelo;
        Imei = imei;
        MemoriaTotal = memoriaTotal;
        MemoriaDisponivel = memoriaTotal;
        AplicativosInstalados = new List<Aplicativo>();
    }

    // Métodos
    public void RealizarChamada(string numero){
        Console.WriteLine($"Chamando {numero}..");
    }

    public void ReceberChamada(string numero) {
        Console.WriteLine($"Recebendo chamada: {numero}");
    }

    public bool VerificarMemoriaDisponivel(int MemoriaDisponivel, int tamanho) {
        return MemoriaDisponivel >= tamanho;
    }

    public void ListarAplicativosInstalados() {
        Console.WriteLine("Aplicativos instalados:");
        
        if (AplicativosInstalados.Count > 0) { // Retorna os aplicativos instalados caso a lista não esteja vazia
            foreach (var Aplicativo in AplicativosInstalados) {
            Console.WriteLine($"{Aplicativo.Nome} - {Aplicativo.Tamanho} MB"); }
            } else {
            Console.WriteLine("Nenhum aplicativo instalado.");
        }
    }

    public Aplicativo DesinstalarAplicativo(string nome) {
        try { // Tratamento de exceção: O aplicativo requisitado pode não existir na lista
        // Encontra o aplicativo na lista de aplicativos instalados
        Aplicativo aplicativo = AplicativosInstalados.Find(a => a.Nome == nome);

        // Remove o aplicativo encontrado
        AplicativosInstalados.Remove(aplicativo);

        // Libera a memória utilizada pelo aplicativo removido
        MemoriaDisponivel = MemoriaDisponivel + aplicativo.Tamanho;

        // Retorna para o usuário
        Console.WriteLine($"{aplicativo.Nome} desinstalado! {aplicativo.Tamanho} MB liberados.");

        // Retorna o aplicativo removido
        return aplicativo;

        } catch (Exception e) { 
            Console.WriteLine("Falha ao desinstalar!");
            Console.WriteLine("Aplicativo não encontrado.");

            return null;
        }
    }

    // Método abstrato (deve chamar o metodo VerificarMemoriaDisponivel)
    public abstract void InstalarAplicativo(string nome, int tamanho);
}