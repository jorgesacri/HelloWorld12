﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HelloWorld12
{
    // Encapsulamento:
    class Produto
    {
        private string _nome; // quando se trabalha com atributo privativo, usa-se '_'+ letra minúscula, Ex: '_nome'
        private int _quantidade;
        private double _preco;

        public Produto(string nome, double preco, int quantidade) // Construtor tem o mesmo nome da classe
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto() { } // Sobrecarga para funcionar o construtor padrão e sintaxe alternativa (Só é necessário quando se declara algum construtor)
        
        //Get:
        public string GetNome() // método Get para a variável nome ser obtida em outras classes
        {
            return _nome;
        }
        //Set:
        public void SetNome(string nome)
        {
            // usando um método como 'Set' é possível colocar uma lógica também.
            if (nome != null && nome.Length > 1) { // 'nome.Length' é usado pra contar o tamanho do string 'nome' (nesse caso maior que 1 letra)
            _nome = nome;
            }
        }

        public double GetPreco() // usando somente o 'Get' para que não posso ser feita alterações fora da classe, somente retornando o valor.
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEsqtoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade; 
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade; 
        }

        public override string ToString() // método usado para retornar a váriavel 'p1' nas informações em String
        {
            return _nome + ", R$:" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " " +
                "Unidades, total R$:" + ValorTotalEmEsqtoque().ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}