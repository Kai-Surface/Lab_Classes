using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Classes
{
    internal class PlayingCards
    {
        int _numOfCardsInDeck;

        enum Material { cardStock , paper , cardboard , cottonPaper
        , plastic}
        Material material;

        enum Use { game , magic , cardistry , cardThrowing , 
            cardHouses , tarot , trade , collecting}
        Use use;

        enum Packaging { deck , pack}
        Packaging packaging;

        bool Coated; //Do the cards have a plastic finish or not

        public int NumOfCardsInDeck { get => _numOfCardsInDeck; set => _numOfCardsInDeck = value; }
        private Material Material1 { get => material; set => material = value; }
        private Use Use1 { get => use; set => use = value; }
        private Packaging Packaging1 { get => packaging; set => packaging = value; }
        public bool Coated1 { get => Coated; set => Coated = value; }
    }
}
