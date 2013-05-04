using System;

namespace ReganRyanSoftwareEngineering {

    public class Card {

        private static int cardNumSeq = 1;

        private int cardNumber;

        private DateTime creationDate;

        private bool activationStatus;

        private int personID;

        public Card() {
            GenerateCardNumber();
            creationDate = DateTime.Now;
            activationStatus = true;
        }

        public void ActivateCard() {
            activationStatus = true;
        }

        public void DeactivateCard() {
            activationStatus = false;
        }

        private void GenerateCardNumber() {
            this.cardNumber = cardNumSeq;
            cardNumSeq++;
        }

        public int GetCardNumber() {
            return cardNumber;
        }

        public bool isActive() {
            return activationStatus;
        }

        public void SetPersonID(int id) {
            this.personID = id;
        }

        public int GetPersonID() {
            return this.personID;
        }

    }

}
