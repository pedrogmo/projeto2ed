using System;

//Pedro Gomes Moreira (18174)
//Samuel Gomes de Lima Dias (18169)

public interface IStack<Dado> where Dado : IComparable<Dado>
{
    void Empilhar(Dado elemento);
    Dado Desempilhar();
    Dado OTopo();
    bool EstaVazia();
    int Tamanho { get; }
}
