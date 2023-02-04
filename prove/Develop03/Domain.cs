using System;
    public class Domain
    {
        private string _reference;
        private string _scripture;
        public Domain()
        {
            _reference = "Unknown";
            _scripture = "Unknown";
        }

        public Domain(string referenceToInput)
        {
            _reference = referenceToInput;
            _scripture = "";
        }
        public Domain(string referenceToInput, string scriptureToInput)
        {
            _reference = referenceToInput;
            _scripture = scriptureToInput;
        }
        public string CompletePhase()
        {
            string phrase = _reference + " " + _scripture;
            return phrase;
        }
    }