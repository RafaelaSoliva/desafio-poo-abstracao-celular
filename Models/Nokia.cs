namespace Models;

public class Nokia : Smartphone{
    // Construção da classe
    public Nokia(string numero, string modelo, string imei, int memoriaTotal) : base(numero, modelo, imei, memoriaTotal) {
    }

    // Implementação do método abstrato
    public override void InstalarAplicativo(string nome) {
        if (VerificarMemoriaDisponivel(MemoriaDisponivel)) {
            MemoriaDisponivel --;
            Console.WriteLine($"{nome} instalado via Google Play!");
        } else {
            Console.WriteLine($"Não há memória disponível para instalar {nome}!");
        }
    }
}