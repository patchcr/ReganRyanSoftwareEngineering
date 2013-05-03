﻿using System;

namespace ReganRyanSoftwareEngineering {

    public class Card {

        private int cardNumber;

        private DateTime creationDate;

        private bool activationStatus;

        private int personID;

        public Card() {
            this.cardNumber = GenerateCardNumber();
            creationDate = DateTime.Now;
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
