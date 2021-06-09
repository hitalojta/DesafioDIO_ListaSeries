using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie> //implementa um repositório da classe Serie
	{ //essa classe repositorio implementa uma interface só que uma classe repositorio de Series
      //está reaproveitando a interface. Vai substituir o <T> por <Serie>
	  //vai ser uma lista que contém todas as séries  
		private List<Serie> listaSerie = new List<Serie>(); //Estancia uma lista de Series
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir(); //podia ser ".RemoveAt(id)", mas se remover do vetor 
			//vai reclassificar os outros itens, ou seja, mudarão de índice do vetor
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}