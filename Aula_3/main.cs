// proposta da aula 3 ira modificar alguns comando na aula 2
using Modelos;

class Aula3{
  static void Main(string[] args){
    Aluno aluno1 = new Aluno();// criação de objeto aluno1
    aluno1.matricula = ("2024ENEl01");// atribuição de valor para matricula do aluno1
    Aluno aluno2 = new Aluno(3){// criação de objeto aluno2
      matricula = "2023ENEl01"// atribuição de valor para matricula do aluno2
    };
    Disciplina disciplina1 = new Disciplina();// criação de objeto disciplina1
    disciplina1.nome = "Portugues"; // atribuição de valor para nome da disciplina1
    
    Disciplina disciplina2 = new Disciplina(3){// criação de objeto disciplina2
    nome= "Matematica" // atribuição de valor para nome da disciplina2 
    };// fim do objeto disciplina2
    
    aluno1.disciplinas.Add(disciplina1);// adiciona a disciplina1 ao aluno1
    aluno2.disciplinas.Add(disciplina1);// adiciona a disciplina2 ao aluno2
    aluno2.disciplinas.Add(disciplina2);// adiciona a disciplina2 ao aluno2
    aluno1.Imprimir();// chama o metodo imprimir do aluno1  
    aluno2.Imprimir();// chama o metodo imprimir do aluno2
  }
}
