// See https://aka.ms/new-console-template for more information


Menu();

static void Menu() {
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1- Abrir o Arquivo");
    Console.WriteLine("2- Criar Novo Arquivo");
    Console.WriteLine("0- Sair do Sistema");

    short option = short.Parse(Console.ReadLine());

    switch(option){
        case 0: SairSistema();break;
        case 1 : AbrirArquivo();break;
        case 2: CriarArquivo();break;
        default: ErrorMenssage();break;

    }

}



static void AbrirArquivo(){
    Console.Clear();
    Console.WriteLine("Abrir Arquivo");
}

static void CriarArquivo() {
    Console.Clear();
    Console.WriteLine("Digite seu texto  abaixo ( Esc para sair) ");
    Console.WriteLine("-------------------------------");
    string text = "";

    do {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while ( Console.ReadKey().Key != ConsoleKey.Escape);
        Console.Write(text);


}


static void SairSistema() {
    Console.Clear();
    Console.WriteLine("Obrigado por usar o Sistema");
    Thread.Sleep(2000);
    System.Environment.Exit(0);

}

static void ErrorMenssage() {
    Console.Clear();
    Console.WriteLine("Opção Inválida");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();

}

