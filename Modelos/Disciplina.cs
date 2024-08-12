// introdução para introdução para manipulação de objeto:
using System;// entrada para uso

namespace Modelos {// namespace para organização do codigo (localição e chamada de codigo dentro da pasta)              
  class Disciplina {// classe para criação de objeto
    // para a realização de manipulação de objeto é necessario criar os atributos ou variaveis para armazenamento de dados
      public string nome;// variavel para armazenar a matricula do aluno
// caso a variavel semestre seja privada o codigo não pode ser acessado por outros objetos

    //public int semestre;// variavel para armazenar o periodo do aluno(aula 2)     

    // caso no codigo da main.cs não tenha declarado um periodo para o aluno o codigo ira imprimir o valor padrão 1 nessa codição: Disciplina disciplina1 = new Disciplina()
    
    public Disciplina() : this(1){// construtor para a aula 3 
    } // fim do construtor
    
    // O codigo observa o valor registrado para o periodo se for maior ou menor que zero para o aluno o codigo
   
    private int semestre;// variavel para armazenar o periodo do aluno
   public Disciplina(int semestre){// construtor para a aula 3
   
      if(semestre > 0){// condição de se periodo for maior a 0
        this.semestre = semestre;// atribuição de valor para semestre da disciplina
      }else{// se não
        this.semestre = 1;// atribuição de valor para periodo do aluno
      }// fim do if
     }// fim do construtor
   
    // para realizar a chamada de um valor ja criado é  possivel de realizar se estiver com outro valor
    
    // Mas como realizar a chamada de função de periodo para ser realizado : utilizamos o this.
    public Disciplina (int semestre , string nome): this(semestre){ 
     if(!String.IsNullOrWhiteSpace(nome)){// condição de se matricula for diferente de vazio( e observa o valor da matricula)
       this.nome = nome;// atribuição de valor para nome da disciplina 
      }// fim do if
    } // fim do construtor

        public Disciplina(string v1, int v2)
        {
        }

        public void Imprimir() {// metodo para imprimir os dados do aluno
        Console.WriteLine("-----------------------");// imprime uma linha de asteriscos
        
        Console.WriteLine("Disciplina");// imprime a palavra aluno
        Console.WriteLine("Nome: " + this.nome);// imprime a matricula do aluno 
        Console.WriteLine("Semestre: " + this.semestre);// imprime o periodo do aluno
        
        Console.WriteLine("-----------------------");// imprime uma linha de asteriscos
      }
    }

}