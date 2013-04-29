using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReganRyanSoftwareEngineering {

   public class CardReaderInstallation {

        private Dictionary<string, CardReader> cardReaders;

        public CardReaderInstallation() {
            cardReaders = new Dictionary<string, CardReader>();
            AddCardReader("1234", "10.0.0.0", new Door(123, new DoorGroup("code", "description")));
        }

        public void AddCardReader(string name, string nat, Door door) {
            cardReaders.Add(name, new CardReader(name, nat, door));
        }

        public CardReader getCardReaderbyID(string id)
        {
            return cardReaders[id];
        }

    }

}
