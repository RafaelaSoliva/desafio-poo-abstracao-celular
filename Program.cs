using Models;

// Cria objeto Iphone
Iphone iphone = new Iphone("99999-9999", "iPhone 16 Pro", "7329349282", 256000);

// Testa todos os metodos da classe Iphone
iphone.RealizarChamada("88888-8888"); // Realiza chamada
iphone.ReceberChamada("88888-8888"); // Recebe chamada
iphone.ListarAplicativosInstalados(); // Retorna mensagem de lista vazia
iphone.InstalarAplicativo("Reddit", 28); // Instala Reddit
iphone.InstalarAplicativo("TIDAL", 200); // Instala TIDAL
iphone.InstalarAplicativo("PUBG", 578000); // Retorna mensagem de falta de memória
iphone.ListarAplicativosInstalados(); // Retorna lista de aplicativos instalados
iphone.DesinstalarAplicativo("Reddit"); // Desinstala Reddit
iphone.DesinstalarAplicativo("Reddit"); // Retorna mensagem de aplicativo não encontrado