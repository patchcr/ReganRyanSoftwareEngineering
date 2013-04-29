using System;

namespace ReganRyanSoftwareEngineering {

    private class Card {

        private int cardNumber;

        private DateTime creationDate;

        private bool activationStatus;

        public Card() {
            this.cardNumber = GenerateCardNumber();
            creationDate = new DateTime();
            activationStatus = true;
        }

        public void ActivateCard() {
            activationStatus = true;
        }

        public void DeactivateCard() {
            activationStatus = false;
        }

        private int GenerateCardNumber() {
            Random random = new Random();
            return random.Next(Int32.MaxValue);
        }

    }

}
