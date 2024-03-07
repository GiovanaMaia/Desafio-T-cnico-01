
using System;
class HelloWorld {
  static void Main() {
     
    int seguidores_mes1=400, seguidores_mes2=1000, visualizacoes1=500, visualizacoes2=1500, escolha1, escolha2;
    float media_seguidores;
    double media_visualizações;
    char a ='!' ,b ='!' ;
    //bool perfil= true, estatistica= true;
    string nome = "ScoobyDoo_O_Melhor", idade= "2anos";
    
    Console.WriteLine("ScoobyDoo, mais conhecido como ScoobyDoby Doo, ou ainda, o cachorro enxerido.");
    Console.WriteLine("É um dos cachorros mais destemidos que existem, isso claro, até seus biscoitos Scooby acabarem.");
    Console.WriteLine("Ele está agora no instagram, selecione uma opção para saber mais:");
    Console.WriteLine("1) Perfil no instagram"+a);
    Console.WriteLine(b+"2) Estatísticas do perfil"+b);
    escolha1= int.Parse(Console.ReadLine());
    
    if (escolha1 == 1 ){
     bool perfil=true;
       Console.WriteLine("Selecione uma opção :"+perfil);
       Console.WriteLine("3) Nome e idade");
       Console.WriteLine("4) Números de seguidores");
       escolha2= int.Parse(Console.ReadLine());
             if (escolha2 == 3){
            Console.WriteLine("Nome de usuário: "+nome);
            Console.WriteLine("Idade: "+idade);
             }
            else if (escolha2 == 4){
            Console.WriteLine("Seguidores: "+seguidores_mes2);
                
            }
        
             else{
    Console.WriteLine("Opção inválida");
    }
    
    }
    else if (escolha1 == 2){
    bool   estatistica = true;
       media_seguidores = (seguidores_mes1+seguidores_mes2)/2;
       media_visualizações = (visualizacoes1+visualizacoes2)/2;
     Console.WriteLine("A média nos últimos dois meses foi de "+media_seguidores+" seguidores."+estatistica);
     Console.WriteLine("A média de visualizações foi de "+ media_visualizações+ estatistica);
 
        
    }
    else {
    Console.WriteLine("Opção inválida");

    }
    }
   
  }
