using RH;


var funcionario = new Funcionario1("Agnos Vilela", "001.002.003.85");

// aqui eu nao tenho acesso ao cpf, mas posso ler.
funcionario.CPF = "005.006.008.00";
Console.WriteLine(funcionario.CPF);



/*Get e Set são a forma mais comum de implementar o 
encapsulamento e é por meio destes métodos que controlamos os detalhes 
internos da classe.*/
