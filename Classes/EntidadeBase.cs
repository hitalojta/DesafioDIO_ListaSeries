namespace DIO.Series //a classe vale para todos nesse namespace
{
    public abstract class EntidadeBase
    { //classe abstrata não se instancia
        public int Id { get; protected set; }
        //protected para ser acessado apenas dentro da propria DLL
        //todos que herdarem terao esse ID por padrão
    }
}

/*
Classes abstratas: Classes que podem conter métodos abstratos.
NÃO PODE SER INSTANCIADA
São "moldes" para outras classes, com propriedades e métodos a serem
herdados. Quem herda dela é obrigado a fazer a implementação.
Um método abstrato é um método que é declarado, porém não contém
implementação
*/