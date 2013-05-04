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

            AddCardReader("cr001", "nat001", DoorAccessController.Instance.Doors[0]);
            AddCardReader("cr002", "nat002", DoorAccessController.Instance.Doors[1]);
            AddCardReader("cr003", "nat003", DoorAccessController.Instance.Doors[2]);
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
