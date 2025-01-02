namespace Models;

public class Iphone : Smartphone{

    public Iphone(string numero, string modelo, string imei, int memoriaTotal) : base(numero, modelo, imei, memoriaTotal) {
    }

    public override void InstalarAplicativo(string nome) {
        if (MemoriaDisponivel > 0) {
            MemoriaDisponivel --;
            Console.WriteLine($"{nome} instalado via App Store!");
        } else {
            Console.WriteLine($"Não há memória disponível para instalar {nome}!");
        }
    }
}