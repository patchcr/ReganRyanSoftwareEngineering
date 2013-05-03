using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReganRyanSoftwareEngineering {

    public class CardReaderInstallation {

        private static CardReaderInstallation instance = new CardReaderInstallation();

        public static CardReaderInstallation Instance {
            get { return instance; }
        }

        private Dictionary<string, CardReader> cardReaders;

        public CardReaderInstallation() {
            cardReaders = new Dictionary<string, CardReader>();
        }

        public Dictionary<string, CardReader> CardReaders {
            get { return cardReaders; }
        }

        public void AddCardReader(string name, string nat, Door door) {
            cardReaders.Add(name, new CardReader(name, nat, door));
        }

        public CardReader GetCardReader(string id) {
            return cardReaders[id];
        }

    }

}
