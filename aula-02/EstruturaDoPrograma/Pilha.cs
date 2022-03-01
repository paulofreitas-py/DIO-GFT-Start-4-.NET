using System;

namespace EstruturaDoPrograma
{
    public class Pilha
    {
        Posicao primeiro;
        public void Empilha(object Item)
        {
            primeiro= new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException();
            }

            object resulktado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultados;
        }
    }
}