using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReganRyanSoftwareEngineering {

    class CardReaderInstallation {

        private Dictionary<string, CardReader> cardReaders;

        public CardReaderInstallation() {
            cardReaders = new Dictionary<string, CardReader>();
        }

        public void AddCardReader(string name, string nat) {
            cardReaders.Add(name, new CardReader(name, nat));
        }

    }

}
