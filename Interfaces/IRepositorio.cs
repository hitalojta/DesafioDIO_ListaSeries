using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T> // quem for implementar essa interface vai poder passar esse T que é um tipo genérico
    {
        List<T> Lista(); //método lista que retorna uma lista de T
        T RetornaPorId(int id); //passa um ID e retorna um T como parâmetro       
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}

/*
Semelhante à classe abstrata, mas não possui atributos e não
pode definir como os métodos devem ser implementados.
Em vez disso, é simplesmente uma lista de métodos que devem ser
implementados.
Uma classe implementa uma ou várias interfaces. Só que cada interface
que for implementar é obrigado a implementar os métodos da interface.
Quem implementar essa interface vai ser obrigado a implementar.
*/