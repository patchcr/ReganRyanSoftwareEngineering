using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReganRyanSoftwareEngineering
{
    class DBCardInterface
    {
        public static DBCardInterface instance = new DBCardInterface();

        public static DBCardInterface GetInstance()
        {
            return instance;
        }

        private Dictionary<String, Card> cards;

        public DBCardInterface()
        {
            cards = new Dictionary<string,Card>();
            
            // TODO Remove this dummy data
            cards.Add("card1", new Card());
            cards.Add("card2", new Card());
        }

        public void AddCard(Card card)
        {
            cards.Add(card.GetCardNumber().ToString(),card);
        }

        public Card GetCard(string number)
        {
            if (number == null) 
            { 
                Card temp = new Card();
                return temp;
            }
            return cards[number];
        }
        public Card GetCard(int number)
        {
            return cards[number.ToString()];
        }

        public Dictionary<String, Card> GetCardList()
        {
            return cards;
        }

        public bool ValidateCard(string number)
        {
            return cards.ContainsKey(number.ToString());
        }
    }
}
