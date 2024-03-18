
string especie = "";
string id = "";
int idade = 0;
string caraFisi = "";
string personalidade = "";
string nome = "";
string busca = "";

int maxPets = 8;
int achou = 0;
int escolha = 0;
int numPets = 0;
string menuSelection = "";
string[,] animais = new string[maxPets, 6];

do{
    Console.Clear();
    Console.WriteLine("Bem-vindo ao app do abrigo Contoso Pets, suas opções são:");
    Console.WriteLine(" 1. Listar informções de nossos animais atuais");
    Console.WriteLine(" 2. Adicionar um novo animal ao abrigo");
    Console.WriteLine(" 3. Editar o nome de um animal");
    Console.WriteLine(" 4. Editar a descrição física de um animal");
    Console.WriteLine(" 5. Editar a idade de um animal");
    Console.WriteLine(" 6. Editar a descrição de personalidade de um animal");
    Console.WriteLine(" 7. Mostrar todos os gatos com uma característica");
    Console.WriteLine(" 8. Mostrar todos os cachorros com uma característica");
    Console.WriteLine();
    Console.WriteLine("Selecione o número da opção pretendida. (ou digite 0 para sair):");
    while(!int.TryParse(Console.ReadLine(), out escolha) || escolha> 8 || escolha<0){
        Console.Clear();
        Console.WriteLine("Bem-vindo ao app do abrigo Contoso Pets, suas opções são:");
        Console.WriteLine(" 1. Listar informções de nossos animais atuais");
        Console.WriteLine(" 2. Adicionar um novo animal ao abrigo");
        Console.WriteLine(" 3. Editar o nome de um animal");
        Console.WriteLine(" 4. Editar a descrição física de um animal");
        Console.WriteLine(" 5. Editar a idade de um animal");
        Console.WriteLine(" 6. Editar a descrição de personalidade de um animal");
        Console.WriteLine(" 7. Mostrar todos os gatos com uma característica");
        Console.WriteLine(" 8. Mostrar todos os cachorros com uma característica");
        Console.WriteLine();
        Console.WriteLine("Selecione o número da opção pretendida. (ou digite 0 para sair):");
    }    
    switch (escolha)
    {
        case 0:
            Console.WriteLine("Tchau tchau! Use nossos serviços sempre que necessário!");
            break;

        case 1:
            if(numPets == 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else{
                for (int i = 0; i < numPets; i++){
                    Console.WriteLine("\n");
                    Console.WriteLine(animais[i, 0]);
                    Console.WriteLine(animais[i, 1]);
                    Console.WriteLine(animais[i, 2]);
                    Console.WriteLine(animais[i, 3]);
                    Console.WriteLine(animais[i, 4]);
                    Console.WriteLine(animais[i, 5]);
                }
            }
            Console.WriteLine("Pressione enter para continuar:");
            Console.ReadLine();
            break;

        case 2:
            if(numPets>=maxPets){
                Console.WriteLine("Infelizmente nosso abrigo está cheio.");
            } else {
                Console.WriteLine("\nVamos adicionar um animal!");
                Console.Write("Digite a espécie do animal:");
                especie = Console.ReadLine();
                while(String.IsNullOrEmpty(especie)){
                    Console.Write("Digite a espécie do animal:");
                    especie = Console.ReadLine();
                }
                Console.Write("Digite o nome do animal:");
                nome = Console.ReadLine();
                while(String.IsNullOrEmpty(nome)){
                    Console.Write("Digite o nome do animal:");
                    nome = Console.ReadLine();
                }
                Console.Write("Digite o id do animal:");
                id = Console.ReadLine();
                while(String.IsNullOrEmpty(id)){
                    Console.Write("Digite o id do animal:");
                    id = Console.ReadLine();
                }
                Console.Write("Digite a idade em anos do animal:");
                while(!int.TryParse(Console.ReadLine(), out idade)){
                    Console.Write("Digite a idade em anos do animal:");
                }
                Console.Write("Digite uma descrição física do animal:");
                caraFisi = Console.ReadLine();
                while(String.IsNullOrEmpty(caraFisi)){
                    Console.Write("Digite uma descrição física do animal:");
                    caraFisi = Console.ReadLine();
                }
                Console.Write("Digite uma descrição da personalidade do animal:");
                personalidade = Console.ReadLine();
                while(String.IsNullOrEmpty(personalidade)){
                    Console.Write("Digite uma descrição da personalidade do animal:");
                    personalidade = Console.ReadLine();
                }
                animais[numPets,0] = "Espécie: " + especie;
                animais[numPets,1] = "Nome: " + nome;
                animais[numPets,2] = "#Id: " + id;
                animais[numPets,3] = "Idade: " + idade + " anos." ;
                animais[numPets,4] = "Descrição física: " + caraFisi;
                animais[numPets,5] = "Personalidade: " +personalidade;
                numPets++;
                Console.WriteLine("Animal adicionado com sucesso!");
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();  
            break;

        case 3 :
            if(numPets== 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else {
                while(achou == 0){
                    Console.Write("Digite o id do animal que quer editar:");
                    busca = Console.ReadLine();
                    while(String.IsNullOrEmpty(busca)){
                        Console.Write("Digite o id do animal que quer editar:");
                        busca = Console.ReadLine();
                    }
                    for(int i = 0; i<numPets;i++){
                        if(animais[i,2].Contains(busca)){
                            achou++;
                            Console.WriteLine("Animal Selecionado:");
                            Console.WriteLine(animais[i, 0]);
                            Console.WriteLine(animais[i, 1]);
                            Console.WriteLine(animais[i, 2]);
                            Console.Write("\nDigite o novo nome do animal:");
                            nome = Console.ReadLine();
                        while(String.IsNullOrEmpty(nome)){
                            Console.Write("Digite o novo nome do animal:");
                            nome = Console.ReadLine();
                        }
                        Console.WriteLine("Nome alterado com sucesso!");
                        animais[i,1] = "Nome: " + nome; 

                        }
                    }
                    if(achou == 0){
                        Console.WriteLine("Infelizmente não achamos nenhum animal com esse id.");
                    }
                    
                }
                achou = 0;
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();  
            break;

        case 4:
            if(numPets== 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else {
                while(achou == 0){
                    Console.Write("Digite o id do animal que quer editar:");
                    busca = Console.ReadLine();
                    while(String.IsNullOrEmpty(busca)){
                        Console.Write("Digite o id do animal que quer editar:");
                        busca = Console.ReadLine();
                    }
                    for(int i = 0; i<numPets;i++){
                        if(animais[i,2].Contains(busca)){
                            achou++;
                            Console.WriteLine("Animal Selecionado:");
                            Console.WriteLine(animais[i, 0]);
                            Console.WriteLine(animais[i, 1]);
                            Console.WriteLine(animais[i, 2]);
                            Console.WriteLine(animais[i, 4]);
                            Console.Write("\nDigite a nova descrição física do animal:");
                            caraFisi = Console.ReadLine();
                        while(String.IsNullOrEmpty(caraFisi)){
                            Console.Write("Digite a nova descrição física do animal:");
                            caraFisi = Console.ReadLine();
                        }
                        Console.WriteLine("Descrição física alterada com sucesso!");
                        animais[i,4] = "Descrição física: " + caraFisi;   
                        } 
                    }
                    if(achou == 0){
                        Console.WriteLine("Infelizmente não achamos nenhum animal com esse id.");
                    }
                    
                }
                achou = 0;
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();  
            break;

        case 5:
            if(numPets== 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else {
                while(achou == 0){
                    Console.Write("Digite o id do animal que quer editar:");
                    busca = Console.ReadLine();
                    while(String.IsNullOrEmpty(busca)){
                        Console.Write("Digite o id do animal que quer editar:");
                        busca = Console.ReadLine();
                    }
                    for(int i = 0; i<numPets;i++){
                        if(animais[i,2].Contains(busca)){
                            achou++;
                            Console.WriteLine("Animal Selecionado:");
                            Console.WriteLine(animais[i, 0]);
                            Console.WriteLine(animais[i, 1]);
                            Console.WriteLine(animais[i, 2]);
                            Console.WriteLine(animais[i, 3]);
                            Console.Write("Digite a nova idade em anos do animal:");
                            while(!int.TryParse(Console.ReadLine(), out idade)){
                                Console.Write("Digite a nova idade em anos do animal:");
                            }
                            Console.WriteLine("Idade alterada com sucesso!");
                            animais[i,3] = "Idade: " + idade + " anos.";  
                        }
                    }
                    if(achou == 0){
                        Console.WriteLine("Infelizmente não achamos nenhum animal com esse id.");
                    }
                    
                }
                achou = 0;
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();  
            break;

        case 6:
            if(numPets== 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else {
                while(achou == 0){
                    Console.Write("Digite o id do animal que quer editar:");
                    busca = Console.ReadLine();
                    while(String.IsNullOrEmpty(busca)){
                        Console.Write("Digite o id do animal que quer editar:");
                        busca = Console.ReadLine();
                    }
                    for(int i = 0; i<numPets;i++){
                        if(animais[i,2].Contains(busca)){
                            achou++;
                            Console.WriteLine("Animal Selecionado:");
                            Console.WriteLine(animais[i, 0]);
                            Console.WriteLine(animais[i, 1]);
                            Console.WriteLine(animais[i, 2]);
                            Console.WriteLine(animais[i, 5]);
                            Console.Write("\nDigite a nova descrição da personalidade do animal:");
                            personalidade = Console.ReadLine();
                        while(String.IsNullOrEmpty(personalidade)){
                            Console.Write("Digite a nova descrição da personalidade do animal:");
                            personalidade = Console.ReadLine();
                        }
                        Console.WriteLine("Descrição da personalidade alterada com sucesso!");
                        animais[i,5] = "Personalidade: " +personalidade;  
                        }
                    }
                    if(achou == 0){
                        Console.WriteLine("Infelizmente não achamos nenhum animal com esse id.");
                    }
                    
                }
                achou = 0;
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();  
            break;

        case 7:
            if(numPets== 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else {
                while(achou == 0){
                    Console.Write("Digite a característica do gato que quer encontrar:");
                    busca = Console.ReadLine();
                    while(String.IsNullOrEmpty(busca)){
                        Console.Write("Digite a característica do gato que quer encontrar:");
                        busca = Console.ReadLine();
                    }
                    for(int i = 0; i<numPets;i++){
                        if((animais[i,0].ToLower()).Contains("gato") && ((animais[i,4].ToLower()).Contains((busca.ToLower())) || (animais[i,5].ToLower()).Contains((busca.ToLower())))){
                            achou++;
                            Console.WriteLine("\nAnimal com a característica selecionada:");
                            Console.WriteLine(animais[i, 0]);
                            Console.WriteLine(animais[i, 1]);
                            Console.WriteLine(animais[i, 2]);
                            Console.WriteLine(animais[i, 3]);
                            Console.WriteLine(animais[i, 4]);
                            Console.WriteLine(animais[i, 5]);
                            continue;
                        }
                    }
                    if(achou == 0){
                        Console.WriteLine("Infelizmente não achamos nenhum gato com essa característica.");
                    }
                    
                }
                achou = 0;
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();  
            break;

        case 8:
            if(numPets== 0){
                Console.WriteLine("Infelizmente ainda não temos animais no abrigo, fique a vontade para doar!");
            } else {
                while(achou == 0){
                    Console.Write("Digite a característica do cachorro que quer encontrar:");
                    busca = Console.ReadLine();
                    while(String.IsNullOrEmpty(busca)){
                        Console.Write("Digite a característica do cachorro que quer encontrar:");
                        busca = Console.ReadLine();
                    }
                    for(int i = 0; i<numPets;i++){
                        if(((animais[i,0].ToLower()).Contains("cão") || (animais[i,0].ToLower()).Contains("cachorro")) && ((animais[i,4].ToLower()).Contains((busca.ToLower())) || (animais[i,5].ToLower()).Contains((busca.ToLower())))){
                            achou++;
                            Console.WriteLine("\nAnimal com a característica selecionada:");
                            Console.WriteLine(animais[i, 0]);
                            Console.WriteLine(animais[i, 1]);
                            Console.WriteLine(animais[i, 2]);
                            Console.WriteLine(animais[i, 3]);
                            Console.WriteLine(animais[i, 4]);
                            Console.WriteLine(animais[i, 5]);
                            continue;
                        }
                    }
                    if(achou == 0){
                        Console.WriteLine("Infelizmente não achamos nenhum gato com essa característica.");
                    }
                    
                }
                achou = 0;
            }
            Console.WriteLine("Pressione enter para continuar:"); 
            Console.ReadLine();
            break;                        
    }
} while (escolha!=0);