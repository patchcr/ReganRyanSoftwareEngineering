using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReganRyanSoftwareEngineering
{
    class DBCardReaderInterface
    {
        public static DBCardReaderInterface instance = new DBCardReaderInterface();

        public static DBCardReaderInterface GetInstance()
        {
            return instance;
        }

        private Dictionary<String, CardReader> cardReaders;

        public DBCardReaderInterface()
        {
            cardReaders = new Dictionary<string,CardReader>();

            // TODO Remove this dummy data
            cardReaders.Add("Well Named",new CardReader("Named", "netAddress", new Door(1234, new DoorGroup("code", "description"))));
            cardReaders.Add("Well Named3", new CardReader("Named3", "netAddress3", new Door(1233, new DoorGroup("code", "description"))));
        }

        public void AddCardReader(CardReader cr)
        {
            cardReaders.Add(cr.getName(),cr);
        }

        public CardReader GetCardReader(string name)
        {
            if (name == null) 
            { 
                CardReader temp = new CardReader("ERROR", "netAddress3", new Door(9999, new DoorGroup("code", "description")));
                return temp;
            }
            return cardReaders[name];
        }

        public Dictionary<String, CardReader> GetCardReadersList()
        {
            return cardReaders;
        }
    }
}
