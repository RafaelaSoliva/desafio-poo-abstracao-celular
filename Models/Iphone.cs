namespace Models;

public class Iphone : Smartphone{
    // Construção da classe
    public Iphone(string numero, string modelo, string imei, int memoriaTotal) : base(numero, modelo, imei, memoriaTotal) {
    }

    // Implementação do método abstrato
    public override void InstalarAplicativo(string nome, int tamanho) {
        bool memoriaDisponivel = VerificarMemoriaDisponivel(MemoriaDisponivel, tamanho);

        if (memoriaDisponivel) {
            MemoriaDisponivel = MemoriaDisponivel - tamanho;
            AplicativosInstalados.Add(new Aplicativo(nome, tamanho));
            Console.WriteLine($"{nome} instalado via App Store!");
        } else {
            Console.WriteLine($"Não há memória disponível para instalar {nome}!");
        }
    }
}