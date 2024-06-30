using System;

namespace word
{
    class Word
    {
        private string _text;
        private bool _isHidden = false;


        public Word(string text)
        {
            _text = text;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            _isHidden = false;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            if (! _isHidden)
            {
                return _text;
            }
            return new string('_', _text.Length);
        }
    }
}