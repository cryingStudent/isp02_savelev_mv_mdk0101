using System;


namespace Prog1
{
    class Notes
    {
        private string serialAndNumber;
        private int denomination;
        private string denominationToString;

        public string SerialAndNumber
        {
            get { return serialAndNumber; }
            set { serialAndNumber = value; }
        }

        public int Denomination
        {
            get { return denomination; }
            set { denomination = value; }
        }

        public string DenominationToString
        {
            get { return denominationToString; }
            set { denominationToString = value; }
        }



        public override string ToString()
        {
            return $"Серия и номер-- {serialAndNumber}, Номинал-- {denomination} руб., Номинал прописью-- {denominationToString} руб.";
        }




    }
}
